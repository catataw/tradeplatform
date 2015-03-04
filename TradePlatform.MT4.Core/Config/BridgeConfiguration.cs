// Type: TradePlatform.MT4.Core.Config.BridgeConfiguration
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System.Configuration;

namespace TradePlatform.MT4.Core.Config
{
  public class BridgeConfiguration : ConfigurationSection
  {
    [ConfigurationProperty("Hosts")]
    public HostElementCollection Hosts
    {
      get
      {
        return this["Hosts"] as HostElementCollection;
      }
    }

    [ConfigurationProperty("wcfBaseAddress", IsKey = true, IsRequired = true)]
    public string WcfBaseAddress
    {
      get
      {
        return (string) this["wcfBaseAddress"];
      }
      set
      {
        this["wcfBaseAddress"] = (object) value;
      }
    }
  }
}
