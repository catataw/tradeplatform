// Type: TradePlatform.MT4.Core.Exceptions.HandlerExecutionException
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.Core.Exceptions
{
  internal class HandlerExecutionException : Exception
  {
    public HandlerExecutionException(ExpertInfo expertInfo, Exception innerException)
      : base(string.Format("Handler execution failed with error '{0}'. Failure Context: {1}", (object) innerException.Message, (object) expertInfo), innerException)
    {
    }
  }
}
