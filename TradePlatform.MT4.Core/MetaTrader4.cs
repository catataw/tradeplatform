// Type: TradePlatform.MT4.Core.MetaTrader4
// Assembly: TradePlatform.MT4.Core, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3C625DF0-7DE3-45D7-A874-EFE88BC90628
// Assembly location: D:\3.6.0.0\Console\TradePlatform.MT4.Core.dll

using System;
using System.Collections.Generic;
using System.Linq;
using TradePlatform.MT4.Core.Exceptions;

namespace TradePlatform.MT4.Core
{
  public class MetaTrader4
  {
    private static readonly Dictionary<string, MetaTrader4> _listeners = new Dictionary<string, MetaTrader4>();
    private static readonly object _listernerLock = new object();
    private readonly Queue<Action<MqlHandler>> _functionsBuffer = new Queue<Action<MqlHandler>>();

    public int AccountNumber { get; private set; }

    public string Symbol { get; private set; }

    public event Action<QuoteListener> QuoteRecieved;

    public event Action<MqlErrorException> MqlError;

    static MetaTrader4()
    {
    }

    private MetaTrader4(int accountNumber, string symbol)
    {
      this.AccountNumber = accountNumber;
      this.Symbol = symbol;
    }

    internal static MetaTrader4 For(int accountNumber, string symbol)
    {
      lock (MetaTrader4._listernerLock)
      {
        string local_0 = (string) (object) accountNumber + (object) symbol;
        if (MetaTrader4._listeners.ContainsKey(local_0))
          return MetaTrader4._listeners[local_0];
        MetaTrader4 local_1 = new MetaTrader4(accountNumber, symbol);
        MetaTrader4._listeners.Add(local_0, local_1);
        return local_1;
      }
    }

    internal static List<MetaTrader4> All()
    {
      lock (MetaTrader4._listernerLock)
        return Enumerable.ToList<MetaTrader4>(Enumerable.Select<KeyValuePair<string, MetaTrader4>, MetaTrader4>((IEnumerable<KeyValuePair<string, MetaTrader4>>) MetaTrader4._listeners, (Func<KeyValuePair<string, MetaTrader4>, MetaTrader4>) (x => x.Value)));
    }

    public void MqlScope(Action<MqlHandler> mqlScope)
    {
      this._functionsBuffer.Enqueue(mqlScope);
    }

    internal void OnQuote(QuoteListener quoteListener)
    {
      while (this._functionsBuffer.Count > 0)
        this._functionsBuffer.Dequeue()((MqlHandler) quoteListener);
      if (this.QuoteRecieved == null)
        return;
      this.QuoteRecieved(quoteListener);
    }

    public void OnMqlError(MqlErrorException mqlErrorException)
    {
      if (this.MqlError == null)
        return;
      this.MqlError(mqlErrorException);
    }
  }
}
