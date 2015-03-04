// Type: TradePlatform.MT4.Core.MqlHandler
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TradePlatform.MT4.Core.Exceptions;
using TradePlatform.MT4.Engine.Log;

namespace TradePlatform.MT4.Core
{
  public abstract class MqlHandler
  {
    internal Func<string, IEnumerable<string>, string> CallMqlInternal;
    public Action<MqlErrorException> MqlError;

    protected internal string Discriminator { get; internal set; }

    protected internal abstract string ResolveMethod(string methodName, List<string> parameters);

    public string CallMqlMethod(string methodName, params object[] parameters)
    {
      try
      {
        IEnumerable<string> collection = parameters == null ? (IEnumerable<string>) (object) new string[0] : Enumerable.Select<object, string>((IEnumerable<object>) parameters, (Func<object, string>) (x => x.ToString()));
        if (this.CallMqlInternal != null)
          return this.CallMqlInternal(methodName, (IEnumerable<string>) new List<string>(collection));
      }
      catch (Exception ex)
      {
        Trace.Write((object) new LogInfo(LogType.Execption, ex, ""));
      }
      return (string) null;
    }
  }
}
