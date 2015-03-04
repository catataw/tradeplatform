// Type: TradePlatform.MT4.Core.QuoterExtensions
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.Core
{
  internal static class QuoterExtensions
  {
    internal static int AccountNumber(this QuoteListener nandler)
    {
      return Convertor.ToInt(nandler.CallMqlMethod("AccountNumber", (object[]) null));
    }

    internal static string Symbol(this QuoteListener handler)
    {
      return handler.CallMqlMethod("Symbol", (object[]) null);
    }
  }
}
