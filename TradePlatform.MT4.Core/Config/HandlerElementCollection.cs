// Type: TradePlatform.MT4.Core.Config.HandlerElementCollection
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System.Configuration;

namespace TradePlatform.MT4.Core.Config
{
  public class HandlerElementCollection : ConfigurationElementCollection
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
        return "Handler";
      }
    }

    public HandlerElement this[int index]
    {
      get
      {
        return (HandlerElement) this.BaseGet(index);
      }
      set
      {
        if (this.BaseGet(index) != null)
          this.BaseRemoveAt(index);
        this.BaseAdd(index, (ConfigurationElement) value);
      }
    }

    public HandlerElement this[string name]
    {
      get
      {
        return (HandlerElement) this.BaseGet((object) name);
      }
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return (ConfigurationElement) new HandlerElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return (object) ((HandlerElement) element).Name;
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
