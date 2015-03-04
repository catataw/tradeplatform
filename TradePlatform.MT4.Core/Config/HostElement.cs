// Type: TradePlatform.MT4.Core.Config.HostElement
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System.Configuration;
using System.Net;

namespace TradePlatform.MT4.Core.Config
{
  public class HostElement : ConfigurationElement
  {
    [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
    public string Name
    {
      get
      {
        return this["name"] as string;
      }
      set
      {
        this["name"] = (object) value;
      }
    }

    [ConfigurationProperty("ipAddress", IsKey = false, IsRequired = true)]
    public string ipAddress
    {
      get
      {
        return this["ipAddress"] as string;
      }
      set
      {
        this["ipAddress"] = (object) value;
      }
    }

    public IPAddress IPAddress
    {
      get
      {
        return IPAddress.Parse(this.ipAddress);
      }
    }

    [ConfigurationProperty("port", DefaultValue = 2007, IsKey = false, IsRequired = true)]
    [IntegerValidator(MaxValue = 3000, MinValue = 2000)]
    public int Port
    {
      get
      {
        return (int) this["port"];
      }
      set
      {
        this["port"] = (object) value;
      }
    }

    [ConfigurationProperty("Handlers")]
    public HandlerElementCollection Handlers
    {
      get
      {
        return this["Handlers"] as HandlerElementCollection;
      }
    }
  }
}
