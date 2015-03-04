// Type: TradePlatform.MT4.SDK.API.WindowFunctions
// Assembly: TradePlatform.MT4.SDK.API, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AFC85038-2E39-4352-9E6F-732551C2A7DA
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.SDK.API.dll

using System;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API
{
  public static class WindowFunctions
  {
    public static void HideTestIndicators(this MqlHandler handler, bool hide)
    {
      handler.CallMqlMethod("HideTestIndicators", new object[1]
      {
        (object) (hide ? 1 : 0)
      });
    }

    public static int Period(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("Period", new object[0]));
    }

    public static bool RefreshRates(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("RefreshRates", new object[0]));
    }

    public static string Symbol(this MqlHandler handler)
    {
      return handler.CallMqlMethod("Symbol", new object[0]);
    }

    public static int WindowBarsPerChart(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("WindowBarsPerChart", new object[0]));
    }

    public static string WindowExpertName(this MqlHandler handler)
    {
      return handler.CallMqlMethod("WindowExpertName", new object[0]);
    }

    public static int WindowFind(this MqlHandler handler, string name)
    {
      return Convertor.ToInt(handler.CallMqlMethod("WindowFind", new object[1]
      {
        (object) name
      }));
    }

    public static int WindowFirstVisibleBar(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("WindowFirstVisibleBar", new object[0]));
    }

    public static int WindowHandle(this MqlHandler handler, string symbol, TIME_FRAME timeframe)
    {
      return Convertor.ToInt(handler.CallMqlMethod("WindowHandle", (object) symbol, (object) timeframe));
    }

    public static bool WindowIsVisible(this MqlHandler handler, int index)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("WindowIsVisible", new object[1]
      {
        (object) index
      }));
    }

    public static int WindowOnDropped(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("WindowOnDropped", new object[0]));
    }

    public static double WindowPriceMax(this MqlHandler handler, int index = 0)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("WindowPriceMax", new object[1]
      {
        (object) index
      }));
    }

    public static double WindowPriceMin(this MqlHandler handler, int index = 0)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("WindowPriceMin", new object[1]
      {
        (object) index
      }));
    }

    public static double WindowPriceOnDropped(this MqlHandler handler)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("WindowPriceOnDropped", new object[0]));
    }

    public static void WindowRedraw(this MqlHandler handler)
    {
      handler.CallMqlMethod("WindowRedraw", new object[0]);
    }

    public static bool WindowScreenShot(this MqlHandler handler, string filename, int size_x, int size_y, int start_bar = -1, int chart_scale = -1, int chart_mode = -1)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("WindowScreenShot", (object) filename, (object) size_x, (object) size_y, (object) start_bar, (object) chart_scale, (object) chart_mode));
    }

    public static DateTime WindowTimeOnDropped(this MqlHandler handler)
    {
      return Convertor.ToDateTime(handler.CallMqlMethod("WindowTimeOnDropped", new object[0]));
    }

    public static int WindowsTotal(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("WindowsTotal", new object[0]));
    }

    public static int WindowXOnDropped(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("WindowXOnDropped", new object[0]));
    }

    public static int WindowYOnDropped(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("WindowYOnDropped", new object[0]));
    }
  }
}
