// Type: TradePlatform.MT4.SDK.API.TradingFunctions
// Assembly: TradePlatform.MT4.SDK.API, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AFC85038-2E39-4352-9E6F-732551C2A7DA
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.SDK.API.dll

using System;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API
{
  public static class TradingFunctions
  {
    public static bool OrderClose(this MqlHandler handler, int ticket, double lots, double price, int slippage, int color = 0)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("OrderClose", (object) ticket, (object) lots, (object) price, (object) slippage, (object) color));
    }

    public static bool OrderCloseBy(this MqlHandler handler, int ticket, int opposite, int color = 0)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("OrderCloseBy", (object) ticket, (object) opposite, (object) color));
    }

    public static double OrderClosePrice(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("OrderClosePrice", (object[]) null));
    }

    public static DateTime OrderCloseTime(this MqlHandler handler)
    {
      return Convertor.ToDateTime(handler.CallMqlMethod("OrderCloseTime", (object[]) null));
    }

    public static string OrderComment(this MqlHandler handler)
    {
      return handler.CallMqlMethod("OrderComment", (object[]) null);
    }

    public static double OrderCommission(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("OrderCommission", (object[]) null));
    }

    public static bool OrderDelete(this MqlHandler handler, int ticket, int color = 0)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("OrderDelete", (object) ticket, (object) color));
    }

    public static DateTime OrderExpiration(this MqlHandler handler)
    {
      return Convertor.ToDateTime(handler.CallMqlMethod("OrderExpiration", (object[]) null));
    }

    public static double OrderLots(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("OrderLots", (object[]) null));
    }

    public static int OrderMagicNumber(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("OrderMagicNumber", (object[]) null));
    }

    public static bool OrderModify(this MqlHandler handler, int ticket, double price, double stoploss, double takeprofit, DateTime expiration = null, int arrow_color = 0)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("OrderModify", (object) ticket, (object) price, (object) stoploss, (object) takeprofit, (object) expiration, (object) arrow_color));
    }

    public static double OrderOpenPrice(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("OrderOpenPrice", (object[]) null));
    }

    public static DateTime OrderOpenTime(this MqlHandler handler)
    {
      return Convertor.ToDateTime(handler.CallMqlMethod("OrderOpenTime", (object[]) null));
    }

    public static void OrderPrint(this MqlHandler handler)
    {
      handler.CallMqlMethod("OrderPrint", (object[]) null);
    }

    public static double OrderProfit(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("OrderProfit", (object[]) null));
    }

    public static bool OrderSelect(this MqlHandler handler, int index, SELECT_BY select, POOL_MODES pool = POOL_MODES.MODE_TRADES)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("OrderSelect", (object) index, (object) select, (object) pool));
    }

    public static int OrderSend(this MqlHandler handler, string symbol, ORDER_TYPE cmd, double volume, double price, int slippage, double stoploss, double takeprofit, string comment = "", int magic = 0, DateTime expiration = null, int arrow_color = 0)
    {
      return Convertor.ToInt(handler.CallMqlMethod("OrderSend", (object) symbol, (object) cmd, (object) volume, (object) price, (object) slippage, (object) stoploss, (object) takeprofit, (object) comment, (object) magic, (object) expiration, (object) arrow_color));
    }

    public static int HistoryTotal(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("HistoryTotal", (object[]) null));
    }

    public static double OrderStopLoss(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("OrderStopLoss", (object[]) null));
    }

    public static int OrdersTotal(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("OrdersTotal", (object[]) null));
    }

    public static double OrderSwap(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("OrderSwap", (object[]) null));
    }

    public static string OrderSymbol(this MqlHandler handler)
    {
      return handler.CallMqlMethod("OrderSymbol", (object[]) null);
    }

    public static double OrderTakeProfit(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("OrderTakeProfit", (object[]) null));
    }

    public static int OrderTicket(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("OrderTicket", (object[]) null));
    }

    public static ORDER_TYPE OrderType(this MqlHandler handler)
    {
      return (ORDER_TYPE) Enum.Parse(typeof (ORDER_TYPE), handler.CallMqlMethod("OrderType", (object[]) null));
    }
  }
}
