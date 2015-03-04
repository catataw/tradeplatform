namespace TradePlatform.MT4.SDK.Library.UnitTests
{
    using System.Diagnostics;
    using TradePlatform.MT4.Core;
    using TradePlatform.MT4.Core.Utils;
    using TradePlatform.MT4.Engine.Log;
    using TradePlatform.MT4.SDK.API;

    public static class PredefinedVariablesTests
    {
        public static void RunTests(MqlHandler script)
        {
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Ask: " + script.Ask() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Bars: " + script.Bars() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Bid: " + script.Bid() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Close: " + script.Close(0) + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Digits: " + script.Digits() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'High: " + script.High(0) + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Low: " + script.Low(0) + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Open: " + script.Open(0) + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Point: " + script.Point() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Time: " + script.Time(0) + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Volume: " + script.Volume() + "'"));
        }
    }
}
