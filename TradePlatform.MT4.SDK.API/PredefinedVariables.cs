// Type: TradePlatform.MT4.SDK.API.PredefinedVariables
// Assembly: TradePlatform.MT4.SDK.API, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AFC85038-2E39-4352-9E6F-732551C2A7DA
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.SDK.API.dll

using System;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API
{
  public static class PredefinedVariables
  {
    public static double Ask(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("Ask", (object[]) null));
    }

    public static int Bars(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("Bars", (object[]) null));
    }

    public static double Bid(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("Bid", (object[]) null));
    }

    public static double Close(this MqlHandler handler, int i)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("Close", new object[1]
      {
        (object) i
      }));
    }

    public static int Digits(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("Digits", (object[]) null));
    }

    public static double High(this MqlHandler handler, int i)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("High", new object[1]
      {
        (object) i
      }));
    }

    public static double Low(this MqlHandler handler, int i)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("Low", new object[1]
      {
        (object) i
      }));
    }

    public static double Open(this MqlHandler handler, int i)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("Open", new object[1]
      {
        (object) i
      }));
    }

    public static double Point(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("Point", (object[]) null));
    }

    public static DateTime Time(this MqlHandler handler, int i)
    {
      return Convertor.ToDateTime(handler.CallMqlMethod("Time", new object[1]
      {
        (object) i
      }));
    }

    public static double Volume(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("Volume", (object[]) null));
    }

    public static int IndicatorCounted(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("IndicatorCounted", (object[]) null));
    }
  }
}
