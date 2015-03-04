// Type: TradePlatform.MT4.Engine.Log.EventLogger
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System.Diagnostics;
using TradePlatform.MT4.Engine.Exceptions;

namespace TradePlatform.MT4.Engine.Log
{
  public abstract class EventLogger : TraceListener
  {
    public abstract void Output(LogInfo info);

    public override void Write(object TraceInfo)
    {
      try
      {
        if (!(TraceInfo is LogInfo))
          throw new TraceListenerException(TraceInfo, "Use 'Write(object)' override and pass 'TraceInfo' instance");
        LogInfo info = TraceInfo as LogInfo;
        this.Output(info);
        if (info.Type != LogType.Execption && info.Type != LogType.HandlerExecutionError)
          return;
        if (!EventLog.SourceExists(((object) info.Type).ToString()))
          EventLog.CreateEventSource(((object) info.Type).ToString(), "TradePlatform.MT4");
        EventLog eventLog = new EventLog();
        eventLog.Source = ((object) info.Type).ToString();
        if (info.Exception != null)
        {
          string message = string.Empty;
          for (; info.Exception != null; info.Exception = info.Exception.InnerException)
            message = message + (object) info.Exception + "\n\n";
          eventLog.WriteEntry(message, EventLogEntryType.Error);
        }
        else
          eventLog.WriteEntry(info.Message, EventLogEntryType.Error);
      }
      catch
      {
      }
    }

    public override void Write(string message)
    {
      throw new TraceListenerException((object) message, "Use 'Write(object)' override and pass 'TraceInfo' instance");
    }

    public override void WriteLine(string message)
    {
      throw new TraceListenerException((object) message, "Use 'Write(object)' override and pass 'TraceInfo' instance");
    }
  }
}
