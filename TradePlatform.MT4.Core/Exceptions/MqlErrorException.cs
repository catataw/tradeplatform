// Type: TradePlatform.MT4.Core.Exceptions.MqlErrorException
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.Core.Exceptions
{
  public class MqlErrorException : Exception
  {
    public MqlErrorException(ExpertInfo expertInfo, MethodCallInfo clientMethodInfo)
      : base(string.Format("MQL returned error: '{0}' for method {1}. Failure Context: {2}", (object) clientMethodInfo.ErrorMessage, (object) clientMethodInfo, (object) expertInfo))
    {
    }
  }
}
