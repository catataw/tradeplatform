// Type: TradePlatform.MT4.Engine.Tasks.PingTask
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System.Collections.Generic;
using System.ComponentModel.Composition;
using TradePlatform.MT4.Data;
using TradePlatform.MT4.Engine.Extension;

namespace TradePlatform.MT4.Engine.Tasks
{
  [MinInterval(5000)]
  [Name("Ping")]
  [Export(typeof (ITask))]
  public class PingTask : ITask
  {
    public string Execute(List<ScheduledTaskParameter> parameters)
    {
      return "*** PING ***";
    }
  }
}
