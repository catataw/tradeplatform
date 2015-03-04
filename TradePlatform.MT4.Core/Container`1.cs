// Type: TradePlatform.MT4.Core.Container`1
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System.Collections.Generic;

namespace TradePlatform.MT4.Core
{
  public abstract class Container<T> where T : new()
  {
    private static Dictionary<string, T> _storage = new Dictionary<string, T>();

    static Container()
    {
    }

    public static T GetOrCreate(string key)
    {
      if (Container<T>._storage.ContainsKey(key))
        return Container<T>._storage[key];
      T obj = new T();
      Container<T>._storage.Add(key, obj);
      return obj;
    }
  }
}
