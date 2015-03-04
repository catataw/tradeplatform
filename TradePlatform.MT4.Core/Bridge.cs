// Type: TradePlatform.MT4.Core.Bridge
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.ServiceModel.Web;
using TradePlatform.MT4.Core.Config;
using TradePlatform.MT4.Core.Internals;
using TradePlatform.MT4.Data;
using TradePlatform.MT4.Engine.Log;

namespace TradePlatform.MT4.Core
{
  public class Bridge
  {
    public static BridgeConfiguration Configuration
    {
      get
      {
        return (BridgeConfiguration) ConfigurationManager.GetSection("BridgeConfiguration");
      }
    }

    public static void InitializeHosts(bool isBackground = false)
    {
      foreach (HostElement hostElement in (ConfigurationElementCollection) Bridge.Configuration.Hosts)
        new HandlerHost(hostElement.Name, hostElement.IPAddress, hostElement.Port, isBackground).Run();
      try
      {
        new WebServiceHost(typeof (TradePlatformDataService), new Uri[1]
        {
          new Uri(Bridge.Configuration.WcfBaseAddress)
        }).Open();
        Trace.Write((object) new LogInfo(LogType.Initializations, (Exception) null, "TradePlatform Data Service is serving at " + Bridge.Configuration.WcfBaseAddress + "\n"));
      }
      catch (Exception ex)
      {
        Trace.Write((object) new LogInfo(LogType.Execption, ex, ""));
      }
    }

    public static List<MetaTrader4> GetTerminals()
    {
      return MetaTrader4.All();
    }

    public static MetaTrader4 GetTerminal(int accountNumber, string symbol)
    {
      return MetaTrader4.For(accountNumber, symbol);
    }
  }
}
