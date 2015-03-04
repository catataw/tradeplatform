// Type: TradePlatform.MT4.Engine.Exceptions.TraceListenerException
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System;

namespace TradePlatform.MT4.Engine.Exceptions
{
  public class TraceListenerException : Exception
  {
    public TraceListenerException(object value, string message)
      : base(string.Format("{0} [Passed Value={1}]", (object) message, value))
    {
    }
  }
}
