// Type: TradePlatform.MT4.Core.Config.ParameterElement
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System.Configuration;

namespace TradePlatform.MT4.Core.Config
{
  public class ParameterElement : ConfigurationElement
  {
    [ConfigurationProperty("propertyName", IsKey = true, IsRequired = true)]
    public string PropertyName
    {
      get
      {
        return this["propertyName"] as string;
      }
      set
      {
        this["propertyName"] = (object) value;
      }
    }

    [ConfigurationProperty("propertyValue", IsKey = false, IsRequired = true)]
    public string PropertyValue
    {
      get
      {
        return this["propertyValue"] as string;
      }
      set
      {
        this["propertyValue"] = (object) value;
      }
    }
  }
}
