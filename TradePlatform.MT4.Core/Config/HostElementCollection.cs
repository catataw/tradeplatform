// Type: TradePlatform.MT4.Core.Config.HostElementCollection
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System.Configuration;

namespace TradePlatform.MT4.Core.Config
{
  public class HostElementCollection : ConfigurationElementCollection
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
        return "Host";
      }
    }

    public HostElement this[int index]
    {
      get
      {
        return (HostElement) this.BaseGet(index);
      }
      set
      {
        if (this.BaseGet(index) != null)
          this.BaseRemoveAt(index);
        this.BaseAdd(index, (ConfigurationElement) value);
      }
    }

    public HostElement this[string name]
    {
      get
      {
        return (HostElement) this.BaseGet((object) name);
      }
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return (ConfigurationElement) new HostElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return (object) ((HostElement) element).Name;
    }

    public bool ContainsKey(string name)
    {
      bool flag = false;
      foreach (string str in this.BaseGetAllKeys())
      {
        if (str == name)
        {
          flag = true;
          break;
        }
      }
      return flag;
    }
  }
}
