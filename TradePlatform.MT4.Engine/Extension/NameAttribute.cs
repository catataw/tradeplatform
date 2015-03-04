// Type: TradePlatform.MT4.Engine.Extension.NameAttribute
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System;
using System.ComponentModel.Composition;

namespace TradePlatform.MT4.Engine.Extension
{
  [MetadataAttribute]
  public class NameAttribute : Attribute
  {
    public string Name { get; private set; }

    public NameAttribute(string name)
    {
      this.Name = name;
    }
  }
}
