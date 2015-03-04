// Type: TradePlatform.MT4.Core.Utils.ExpertInfo
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

namespace TradePlatform.MT4.Core.Utils
{
  public sealed class ExpertInfo
  {
    public readonly string HandlerName;
    public readonly string Discriminator;
    public readonly MethodCallInfo MethodCallInfo;

    public ExpertInfo(string discriminator, string handlerName, MethodCallInfo methodCallInfo)
    {
      this.Discriminator = discriminator;
      this.HandlerName = handlerName;
      this.MethodCallInfo = methodCallInfo;
    }

    public override string ToString()
    {
      return "[HandlerName=" + (object) this.HandlerName + ", Discriminator=" + this.Discriminator + "]." + (string) (object) this.MethodCallInfo;
    }
  }
}
