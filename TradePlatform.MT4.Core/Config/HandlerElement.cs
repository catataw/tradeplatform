// Type: TradePlatform.MT4.Core.Config.HandlerElement
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System.Configuration;

namespace TradePlatform.MT4.Core.Config
{
  public class HandlerElement : ConfigurationElement
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

    [ConfigurationProperty("typeName", IsKey = false, IsRequired = true)]
    public string TypeName
    {
      get
      {
        return this["typeName"] as string;
      }
      set
      {
        this["typeName"] = (object) value;
      }
    }

    [ConfigurationProperty("assemblyName", IsKey = false, IsRequired = true)]
    public string AssemblyName
    {
      get
      {
        return this["assemblyName"] as string;
      }
      set
      {
        this["assemblyName"] = (object) value;
      }
    }

    [ConfigurationProperty("Parameters")]
    public ParameterElementCollection InputParameters
    {
      get
      {
        return this["Parameters"] as ParameterElementCollection;
      }
    }
  }
}
