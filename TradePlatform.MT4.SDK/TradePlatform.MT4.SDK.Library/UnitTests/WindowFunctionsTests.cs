namespace TradePlatform.MT4.SDK.Library.UnitTests
{
    using System.Diagnostics;
    using TradePlatform.MT4.Core;
    using TradePlatform.MT4.Core.Utils;
    using TradePlatform.MT4.Engine.Log;
    using TradePlatform.MT4.SDK.API;

    public static class WindowFunctionsTests
    {
        public static void RunTests(MqlHandler script)
        {
            script.HideTestIndicators(false);
            script.WindowRedraw();

            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'Period: " + script.Period() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'RefreshRates: " + script.RefreshRates() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowBarsPerChart: " + script.WindowBarsPerChart() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowExpertName: " + script.WindowExpertName() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowFind: " + script.WindowFind("Test") + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowFirstVisibleBar: " + script.WindowFirstVisibleBar() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowHandle: " + script.WindowHandle(SYMBOLS.EURUSD, TIME_FRAME.PERIOD_H1) + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowIsVisible: " + script.WindowIsVisible(0) + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowOnDropped: " + script.WindowOnDropped() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowPriceMax: " + script.WindowPriceMax() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowPriceMin: " + script.WindowPriceMin() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowPriceOnDropped: " + script.WindowPriceOnDropped() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowScreenShot: " + script.WindowScreenShot("test.bmp", 200, 200) + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowTimeOnDropped: " + script.WindowTimeOnDropped() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowsTotal: " + script.WindowsTotal() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowXOnDropped: " + script.WindowXOnDropped() + "'"));
            Trace.Write(new LogInfo(LogType.Notifications, message: "Test 'WindowYOnDropped: " + script.WindowYOnDropped() + "'"));
        }
    }
}
