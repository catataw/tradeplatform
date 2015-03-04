// Type: TradePlatform.MT4.Core.Config.ParameterElementCollection
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace TradePlatform.MT4.Core.Config
{
  public class ParameterElementCollection : ConfigurationElementCollection
  {
    public override ConfigurationElementCollectionType CollectionType
    {
      get
      {
        return ConfigurationElementCollectionType.BasicMap;
      }
    }

    protected override string ElementName
    {
      get
      {
        return "Parameter";
      }
    }

    public ParameterElement this[int index]
    {
      get
      {
        return (ParameterElement) this.BaseGet(index);
      }
      set
      {
        if (this.BaseGet(index) != null)
          this.BaseRemoveAt(index);
        this.BaseAdd(index, (ConfigurationElement) value);
      }
    }

    public ParameterElement this[string propertyName]
    {
      get
      {
        return (ParameterElement) this.BaseGet((object) propertyName);
      }
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return (ConfigurationElement) new ParameterElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return (object) ((ParameterElement) element).PropertyName;
    }

    public bool ContainsKey(string propertyName)
    {
      return Enumerable.Any<object>((IEnumerable<object>) this.BaseGetAllKeys(), (Func<object, bool>) (obj => (string) obj == propertyName));
    }
  }
}
