// Type: TradePlatform.MT4.SDK.API.Checkup
// Assembly: TradePlatform.MT4.SDK.API, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AFC85038-2E39-4352-9E6F-732551C2A7DA
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.SDK.API.dll

using System;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;
using TradePlatform.MT4.SDK.API.Constants;

namespace TradePlatform.MT4.SDK.API
{
  public static class Checkup
  {
    public static string GetLastError(this MqlHandler handler)
    {
      return handler.CallMqlMethod("GetLastError", new object[0]);
    }

    public static bool IsConnected(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsConnected", new object[0]));
    }

    public static bool IsDemo(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsDemo", new object[0]));
    }

    public static bool IsDllsAllowed(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsDllsAllowed", new object[0]));
    }

    public static bool IsExpertEnabled(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsExpertEnabled", new object[0]));
    }

    public static bool IsLibrariesAllowed(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsLibrariesAllowed", new object[0]));
    }

    public static bool IsOptimization(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsOptimization", new object[0]));
    }

    public static bool IsStopped(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsStopped", new object[0]));
    }

    public static bool IsTesting(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsTesting", new object[0]));
    }

    public static bool IsTradeAllowed(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsTradeAllowed", new object[0]));
    }

    public static bool IsTradeContextBusy(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsTradeContextBusy", new object[0]));
    }

    public static bool IsVisualMode(this MqlHandler handler)
    {
      return Convertor.ToBoolean(handler.CallMqlMethod("IsVisualMode", new object[0]));
    }

    public static UNINITIALIZE_REASON UninitializeReason(this MqlHandler handler)
    {
      return (UNINITIALIZE_REASON) Enum.Parse(typeof (UNINITIALIZE_REASON), handler.CallMqlMethod("UninitializeReason", new object[0]));
    }
  }
}
