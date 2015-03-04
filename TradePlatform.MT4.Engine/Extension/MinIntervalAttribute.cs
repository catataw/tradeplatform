// Type: TradePlatform.MT4.Engine.Extension.MinIntervalAttribute
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System;
using System.ComponentModel.Composition;

namespace TradePlatform.MT4.Engine.Extension
{
  [MetadataAttribute]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class MinIntervalAttribute : Attribute
  {
    public int MinInterval { get; private set; }

    public MinIntervalAttribute(int milliseconds)
    {
      this.MinInterval = milliseconds;
    }
  }
}
