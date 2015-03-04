// Type: TradePlatform.MT4.Core.ExpertAdvisor
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System;
using System.Collections.Generic;

namespace TradePlatform.MT4.Core
{
  public abstract class ExpertAdvisor : MqlHandler
  {
    protected abstract int Init();

    protected abstract int Start();

    protected abstract int DeInit();

    protected internal override string ResolveMethod(string methodName, List<string> parameters)
    {
      switch (methodName)
      {
        case "Init":
          return this.Init().ToString();
        case "Start":
          return this.Start().ToString();
        case "DeInit":
          return this.DeInit().ToString();
        default:
          throw new Exception("No method found");
      }
    }
  }
}
