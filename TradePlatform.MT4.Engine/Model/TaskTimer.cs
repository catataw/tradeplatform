// Type: TradePlatform.MT4.Engine.Model.TaskTimer
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System;
using System.Diagnostics;
using System.Threading;
using TradePlatform.MT4.Engine.Log;

namespace TradePlatform.MT4.Engine.Model
{
  internal class TaskTimer
  {
    private TaskEvaluator evaluater;

    public TaskTimer(TaskEvaluator container)
    {
      this.evaluater = container;
    }

    public void Run()
    {
      Thread.CurrentThread.Name = "Task Engine Worker";
      Trace.Write((object) new LogInfo(LogType.Initializations, (Exception) null, "Task Engine Initialized."));
      while (true)
      {
        try
        {
          this.evaluater.CheckNow();
        }
        catch (Exception ex)
        {
          Trace.Write((object) new LogInfo(LogType.Execption, ex, ""));
        }
        Thread.Sleep(1000);
      }
    }
  }
}
