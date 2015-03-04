// Type: TradePlatform.MT4.Engine.Model.TaskEvaluator
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using TradePlatform.MT4.Data;
using TradePlatform.MT4.Engine.Log;

namespace TradePlatform.MT4.Engine.Model
{
  internal class TaskEvaluator
  {
    private IEnumerable<TaskInfo> _tasks;

    public TaskEvaluator(IEnumerable<TaskInfo> tasks)
    {
      this._tasks = tasks;
    }

    public void CheckNow()
    {
      using (TradePlatformEntities platformEntities = new TradePlatformEntities())
      {
        ObjectSet<ScheduledTask> scheduledTasks = platformEntities.ScheduledTasks;
        Expression<Func<ScheduledTask, bool>> predicate = (Expression<Func<ScheduledTask, bool>>) (x => x.IsActive && x.State != "Running");
        foreach (ScheduledTask scheduledTask1 in Enumerable.ToList<ScheduledTask>((IEnumerable<ScheduledTask>) Queryable.Where<ScheduledTask>((IQueryable<ScheduledTask>) scheduledTasks, predicate)))
        {
          ScheduledTask scheduledTask = scheduledTask1;
          TaskInfo taskInfo = Enumerable.SingleOrDefault<TaskInfo>(Enumerable.Where<TaskInfo>(this._tasks, (Func<TaskInfo, bool>) (x => x.Name == scheduledTask.Name)));
          if (taskInfo != null)
          {
            int num = Enumerable.Max((IEnumerable<int>) new int[2]
            {
              scheduledTask.Interval,
              (int) taskInfo.MinInterval.TotalMilliseconds
            });
            if (scheduledTask.LastExecution.HasValue)
            {
              DateTime? lastExecution = scheduledTask.LastExecution;
              TimeSpan timeSpan = TimeSpan.FromMilliseconds((double) num);
              DateTime? nullable = lastExecution.HasValue ? new DateTime?(lastExecution.GetValueOrDefault() + timeSpan) : new DateTime?();
              DateTime now = DateTime.Now;
              if ((nullable.HasValue ? (nullable.GetValueOrDefault() < now ? 1 : 0) : 0) == 0)
                continue;
            }
            scheduledTask.State = "Running";
            Trace.Write((object) new LogInfo(LogType.Initializations, (Exception) null, "Running '" + scheduledTask.Name + "' task..."));
            taskInfo.Patameters = Enumerable.ToList<ScheduledTaskParameter>((IEnumerable<ScheduledTaskParameter>) scheduledTask.ScheduledTaskParameters);
            Task task = new Task((Action<object>) (x => ((TaskInfo) x).ExecuteTask()), (object) taskInfo);
            task.ContinueWith(new Action<Task>(this.TaskCompleted));
            task.Start();
          }
          else
          {
            scheduledTask.State = "Missing";
            Trace.Write((object) new LogInfo(LogType.Notifications, (Exception) null, "Missing implementation for task '" + scheduledTask.Name + "'"));
          }
        }
        platformEntities.SaveChanges();
      }
    }

    private void TaskCompleted(Task task)
    {
      try
      {
        using (TradePlatformEntities platformEntities = new TradePlatformEntities())
        {
          ScheduledTask scheduledTask = Queryable.SingleOrDefault<ScheduledTask>(Queryable.Where<ScheduledTask>((IQueryable<ScheduledTask>) platformEntities.ScheduledTasks, (Expression<Func<ScheduledTask, bool>>) (y => y.Name == ((TaskInfo) task.AsyncState).Name)));
          if (scheduledTask == null)
            return;
          Thread.CurrentThread.Name = "Task: '" + scheduledTask.Name + "' Callback";
          scheduledTask.LastExecution = new DateTime?(DateTime.Now);
          string taskExecutionResult = ((TaskInfo) task.AsyncState).TaskExecutionResult;
          Trace.Write((object) new LogInfo(LogType.Workflow, (Exception) null, "Execution Result: " + taskExecutionResult));
          scheduledTask.LastMessage = taskExecutionResult;
          if (scheduledTask.Type == "Once")
          {
            scheduledTask.State = "Completed";
            scheduledTask.IsActive = false;
            Trace.Write((object) new LogInfo(LogType.Initializations, (Exception) null, "Single execution completed.\n"));
          }
          if (scheduledTask.Type == "Infinity")
          {
            scheduledTask.State = "Waiting";
            Trace.Write((object) new LogInfo(LogType.Initializations, (Exception) null, "Next execution completed.\n"));
          }
          if (scheduledTask.Type == "Countdown")
          {
            scheduledTask.State = "Waiting";
            --scheduledTask.Executions;
            if (scheduledTask.Executions == 0)
            {
              scheduledTask.State = "Completed";
              scheduledTask.IsActive = false;
              Trace.Write((object) new LogInfo(LogType.Initializations, (Exception) null, "Countdown executions completed\n"));
            }
            else
              Trace.Write((object) new LogInfo(LogType.Initializations, (Exception) null, "Next execution completed. Left: " + (object) scheduledTask.Executions + "\n"));
          }
          if (task.IsFaulted)
          {
            scheduledTask.LastError = task.Exception.InnerException.Message;
            Trace.Write((object) new LogInfo(LogType.HandlerExecutionError, (Exception) null, "Task execution failed with an error: " + task.Exception.InnerException.Message + "\n"));
          }
          platformEntities.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        Trace.Write((object) new LogInfo(LogType.Execption, ex, ""));
      }
    }
  }
}
