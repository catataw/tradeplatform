// Type: TradePlatform.MT4.SDK.API.TechnicalIndicators
// Assembly: TradePlatform.MT4.SDK.API, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AFC85038-2E39-4352-9E6F-732551C2A7DA
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.SDK.API.dll

using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API
{
  public static class TechnicalIndicators
  {
    public static double iAC(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iAC", (object) symbol, (object) timeframe, (object) shift));
    }

    public static double iAD(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iAD", (object) symbol, (object) timeframe, (object) shift));
    }

    public static double iAlligator(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int jaw_period, int jaw_shift, int teeth_period, int teeth_shift, int lips_period, int lips_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, GATOR_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iAlligator", (object) symbol, (object) timeframe, (object) jaw_period, (object) jaw_shift, (object) teeth_period, (object) teeth_shift, (object) lips_period, (object) lips_shift, (object) ma_method, (object) appliedApplyPrice, (object) mode, (object) shift));
    }

    public static double iADX(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, ADX_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iADX", (object) symbol, (object) timeframe, (object) period, (object) appliedApplyPrice, (object) mode, (object) shift));
    }

    public static double iATR(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iATR", (object) symbol, (object) timeframe, (object) period, (object) shift));
    }

    public static double iAO(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iAO", (object) symbol, (object) timeframe, (object) shift));
    }

    public static double iBearsPower(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iBearsPower", (object) symbol, (object) timeframe, (object) period, (object) shift));
    }

    public static double iBands(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int deviation, int bands_shift, APPLY_PRICE appliedApplyPrice, BAND_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iBands", (object) symbol, (object) timeframe, (object) period, (object) deviation, (object) bands_shift, (object) appliedApplyPrice, (object) mode, (object) shift));
    }

    public static double iBullsPower(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iBullsPower", (object) symbol, (object) timeframe, (object) period, (object) appliedApplyPrice, (object) shift));
    }

    public static double iCCI(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iCCI", (object) symbol, (object) timeframe, (object) period, (object) appliedApplyPrice, (object) shift));
    }

    public static double iDeMarker(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iDeMarker", (object) symbol, (object) timeframe, (object) period, (object) shift));
    }

    public static double iEnvelopes(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int ma_period, MA_METHOD ma_method, int ma_shift, APPLY_PRICE appliedApplyPrice, double deviation, BAND_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iEnvelopes", (object) symbol, (object) timeframe, (object) ma_period, (object) ma_method, (object) ma_shift, (object) appliedApplyPrice, (object) deviation, (object) mode, (object) shift));
    }

    public static double iForce(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iForce", (object) symbol, (object) timeframe, (object) period, (object) ma_method, (object) appliedApplyPrice, (object) shift));
    }

    public static double iFractals(this MqlHandler handler, string symbol, TIME_FRAME timeframe, BAND_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iFractals", (object) symbol, (object) timeframe, (object) mode, (object) shift));
    }

    public static double iGator(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int jaw_period, int jaw_shift, int teeth_period, int teeth_shift, int lips_period, int lips_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, BAND_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iGator", (object) symbol, (object) timeframe, (object) jaw_period, (object) jaw_shift, (object) teeth_period, (object) teeth_shift, (object) lips_period, (object) lips_shift, (object) ma_method, (object) appliedApplyPrice, (object) mode, (object) shift));
    }

    public static double iIchimoku(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int tenkan_sen, int kijun_sen, int senkou_span_b, ICHIMOKU_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iIchimoku", (object) symbol, (object) timeframe, (object) tenkan_sen, (object) kijun_sen, (object) senkou_span_b, (object) mode, (object) shift));
    }

    public static double iBWMFI(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iBWMFI", (object) symbol, (object) timeframe, (object) shift));
    }

    public static double iMomentum(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iMomentum", (object) symbol, (object) timeframe, (object) period, (object) appliedApplyPrice, (object) shift));
    }

    public static double iMFI(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iMFI", (object) symbol, (object) timeframe, (object) period, (object) shift));
    }

    public static double iMA(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int ma_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iMA", (object) symbol, (object) timeframe, (object) period, (object) ma_shift, (object) ma_method, (object) appliedApplyPrice, (object) shift));
    }

    public static double iOsMA(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int fast_ema_period, int slow_ema_period, int signal_period, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iOsMA", (object) symbol, (object) timeframe, (object) fast_ema_period, (object) slow_ema_period, (object) signal_period, (object) appliedApplyPrice, (object) shift));
    }

    public static double iMACD(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int fast_ema_period, int slow_ema_period, int signal_period, APPLY_PRICE appliedApplyPrice, MACD_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iMACD", (object) symbol, (object) timeframe, (object) fast_ema_period, (object) slow_ema_period, (object) signal_period, (object) appliedApplyPrice, (object) mode, (object) shift));
    }

    public static double iOBV(this MqlHandler handler, string symbol, TIME_FRAME timeframe, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iOBV", (object) symbol, (object) timeframe, (object) appliedApplyPrice, (object) shift));
    }

    public static double iSAR(this MqlHandler handler, string symbol, TIME_FRAME timeframe, double step, double maximum, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iSAR", (object) symbol, (object) timeframe, (object) step, (object) maximum, (object) shift));
    }

    public static double iRSI(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iRSI", (object) symbol, (object) timeframe, (object) period, (object) appliedApplyPrice, (object) shift));
    }

    public static double iRVI(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, MACD_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iRVI", (object) symbol, (object) timeframe, (object) period, (object) mode, (object) shift));
    }

    public static double iStdDev(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int ma_period, int ma_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iStdDev", (object) symbol, (object) timeframe, (object) ma_period, (object) ma_shift, (object) ma_method, (object) appliedApplyPrice, (object) shift));
    }

    public static double iStochastic(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int Kperiod, int Dperiod, int slowing, MA_METHOD method, APPLY_PRICE applyPriceField, MACD_MODE mode, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iStochastic", (object) symbol, (object) timeframe, (object) Kperiod, (object) Dperiod, (object) slowing, (object) method, (object) applyPriceField, (object) mode, (object) shift));
    }

    public static double iWPR(this MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int shift)
    {
      return Convertor.ToDouble(handler.CallMqlMethod("iWPR", (object) symbol, (object) timeframe, (object) period, (object) shift));
    }
  }
}
