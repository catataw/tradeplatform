// Type: TradePlatform.MT4.Engine.Log.ConsoleLogger
// Assembly: TradePlatform.MT4.Engine, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E31D53C8-EE19-4156-87F8-BF615A969265
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Engine.dll

using System;

namespace TradePlatform.MT4.Engine.Log
{
  public class ConsoleLogger : EventLogger
  {
    public override void Output(LogInfo info)
    {
      switch (info.Type)
      {
        case LogType.Execption:
          Console.BackgroundColor = ConsoleColor.Red;
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine(info.Message);
          break;
        case LogType.HandlerExecutionError:
          Console.BackgroundColor = ConsoleColor.Blue;
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine(info.Message);
          break;
        case LogType.MqlError:
          Console.BackgroundColor = ConsoleColor.Yellow;
          Console.ForegroundColor = ConsoleColor.Black;
          Console.WriteLine(info.Message);
          break;
        case LogType.Initializations:
          Console.BackgroundColor = ConsoleColor.Black;
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine(info.Message);
          break;
        case LogType.Workflow:
          Console.BackgroundColor = ConsoleColor.Black;
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.WriteLine(info.Message);
          break;
        case LogType.Notifications:
          Console.BackgroundColor = ConsoleColor.Black;
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine(info.Message);
          break;
        default:
          throw new ArgumentOutOfRangeException("Type");
      }
    }
  }
}
