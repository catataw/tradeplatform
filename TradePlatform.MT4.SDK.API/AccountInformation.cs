// Type: TradePlatform.MT4.SDK.API.AccountInformation
// Assembly: TradePlatform.MT4.SDK.API, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AFC85038-2E39-4352-9E6F-732551C2A7DA
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.SDK.API.dll

using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API
{
  public static class AccountInformation
  {
    public static double AccountBalance(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("AccountBalance", (object[]) null));
    }

    public static double AccountCredit(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("AccountCredit", (object[]) null));
    }

    public static string AccountCompany(this MqlHandler handler)
    {
      return handler.CallMqlMethod("AccountCompany", (object[]) null);
    }

    public static string AccountCurrency(this MqlHandler handler)
    {
      return handler.CallMqlMethod("AccountCurrency", (object[]) null);
    }

    public static double AccountEquity(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("AccountEquity", (object[]) null));
    }

    public static double AccountFreeMargin(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("AccountFreeMargin", (object[]) null));
    }

    public static double AccountFreeMarginCheck(this MqlHandler handler, string symbol, ORDER_TYPE cmd, double volume)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("AccountFreeMarginCheck", (object) symbol, (object) cmd, (object) volume));
    }

    public static double AccountFreeMarginMode(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("AccountFreeMarginMode", (object[]) null));
    }

    public static int AccountLeverage(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("AccountLeverage", (object[]) null));
    }

    public static double AccountMargin(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("AccountMargin", (object[]) null));
    }

    public static string AccountName(this MqlHandler handler)
    {
      return handler.CallMqlMethod("AccountName", (object[]) null);
    }

    public static int AccountNumber(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("AccountNumber", (object[]) null));
    }

    public static double AccountProfit(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("AccountProfit", (object[]) null));
    }

    public static string AccountServer(this MqlHandler handler)
    {
      return handler.CallMqlMethod("AccountServer", (object[]) null);
    }

    public static int AccountStopoutLevel(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("AccountStopoutLevel", (object[]) null));
    }

    public static int AccountStopoutMode(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("AccountStopoutMode", (object[]) null));
    }
  }
}
