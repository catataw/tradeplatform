// Type: TradePlatform.MT4.Engine.Extension.ITask
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System.Collections.Generic;
using TradePlatform.MT4.Data;

namespace TradePlatform.MT4.Engine.Extension
{
  public interface ITask
  {
    string Execute(List<ScheduledTaskParameter> patameters);
  }
}
