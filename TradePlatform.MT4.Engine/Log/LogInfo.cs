// Type: TradePlatform.MT4.Engine.Log.LogInfo
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System;
using System.Threading;

namespace TradePlatform.MT4.Engine.Log
{
  public class LogInfo
  {
    public LogType Type;
    public Exception Exception;
    public string Message;

    public LogInfo(LogType type, Exception exception = null, string message = "")
    {
      this.Type = type;
      this.Exception = exception;
      this.Message = string.Format(" {0} @ {1} : {2}", (object) DateTime.Now, (object) (Thread.CurrentThread.Name ?? ""), (object) ((exception == null ? "" : exception.Message) + ", " + message));
    }

    public override string ToString()
    {
      return this.Message;
    }
  }
}
