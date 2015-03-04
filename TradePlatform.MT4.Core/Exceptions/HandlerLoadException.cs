// Type: TradePlatform.MT4.Core.Exceptions.HandlerLoadException
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.Core.Exceptions
{
  internal class HandlerLoadException : Exception
  {
    public HandlerLoadException(ExpertInfo expertInfo, string reason, Exception innerException)
      : base(string.Format("Can't load handler: {0}. Failure Context: {1}", (object) reason, (object) expertInfo), innerException)
    {
    }
  }
}
