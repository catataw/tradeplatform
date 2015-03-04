// Type: TradePlatform.MT4.SDK.API.CommonFunctions
// Assembly: TradePlatform.MT4.SDK.API, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AFC85038-2E39-4352-9E6F-732551C2A7DA
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.SDK.API.dll

using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API
{
  public static class CommonFunctions
  {
    public static void Alert(this MqlHandler handler, string message)
    {
      handler.CallMqlMethod("Alert", new object[1]
      {
        (object) message
      });
    }

    public static void Comment(this MqlHandler handler, string message)
    {
      handler.CallMqlMethod("Comment", new object[1]
      {
        (object) message
      });
    }

    public static int GetTickCount(this MqlHandler handler)
    {
      return Convertor.ToInt(handler.CallMqlMethod("GetTickCount", (object[]) null));
    }

    public static double MarketInfo(this MqlHandler handler, string symbol, MARKER_INFO_MODE mode)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("MarketInfo", (object) symbol, (object) mode));
    }

    public static void PlaySound(this MqlHandler handler, string filename)
    {
      handler.CallMqlMethod("PlaySound", new object[1]
      {
        (object) filename
      });
    }

    public static void Print(this MqlHandler handler, string message)
    {
      handler.CallMqlMethod("Print", new object[1]
      {
        (object) message
      });
    }

    public static bool SendNotification(this MqlHandler handler, string notification)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("SendNotification", new object[1]
      {
        (object) notification
      }));
    }
  }
}
