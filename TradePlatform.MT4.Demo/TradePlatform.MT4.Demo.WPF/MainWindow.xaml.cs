using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TradePlatform.MT4.Demo.WPF
{
    using TradePlatform.MT4.Core;
    using TradePlatform.MT4.Core.Exceptions;
    using TradePlatform.MT4.SDK.API;

    public partial class MainWindow : Window
    {
        private MetaTrader4 metaTrader4;
        private int OrderCount = 0;
        private int HistoryCount = 0;

        public MainWindow()
        {
            InitializeComponent();

            Bridge.InitializeHosts(true);

            metaTrader4 = Bridge.GetTerminal(2088782777, "EURUSD.arm");
            metaTrader4.QuoteRecieved += metaTrader4_QuoteRecieved;
            metaTrader4.MqlError += metaTrader4_MqlError;
        }

        private void metaTrader4_MqlError(MqlErrorException mql)
        {
            // handler mql error
        }

        private void metaTrader4_QuoteRecieved(QuoteListener mql)
        {
            if (OrderCount != mql.OrdersTotal())
            {
                this.Dispatcher.BeginInvoke((Action)(() => { DataGridOpen.Items.Clear(); }));
                
                for (int i = mql.OrdersTotal() - 1; i >= 0; i--)
                {
                    if (mql.OrderSelect(i, SELECT_BY.SELECT_BY_POS))
                    {
                        int orderTicket = mql.OrderTicket();
                        string orderSymbol = mql.OrderSymbol();
                        double orderLots = mql.OrderLots();
                        double orderProfit = mql.OrderProfit();

                        var data = new DataGridRowAdd { OrderTicket = orderTicket, Symbol = orderSymbol, Size = orderLots, Profit = orderProfit};

                        this.Dispatcher.BeginInvoke((Action)(() => { DataGridOpen.Items.Add(data); }));
                    }
                }
            }

            if (HistoryCount != mql.HistoryTotal())
            {
                this.Dispatcher.BeginInvoke((Action)(() => { DataGridHistory.Items.Clear(); }));

                for (int i = mql.HistoryTotal() - 1; i >= 0; i--)
                {
                    if (mql.OrderSelect(i, SELECT_BY.SELECT_BY_POS, POOL_MODES.MODE_HISTORY))
                    {
                        int orderTicket = mql.OrderTicket();
                        string orderSymbol = mql.OrderSymbol();
                        double orderLots = mql.OrderLots();
                        double orderProfit = mql.OrderProfit();

                        var data = new DataGridRowAdd { OrderTicket = orderTicket, Symbol = orderSymbol, Size = orderLots, Profit = orderProfit};

                        this.Dispatcher.BeginInvoke((Action)(() => { DataGridHistory.Items.Add(data); }));
                    }
                }
            }

            HistoryCount = mql.HistoryTotal();
            OrderCount = mql.OrdersTotal();

            double bid = mql.Bid();
            double ask = mql.Ask();

            this.Dispatcher.BeginInvoke((Action)(() => { BidPrice.Content = "Bid: " + bid.ToString(); }));
            this.Dispatcher.BeginInvoke((Action)(() => { AskPrice.Content = "Ask: " + ask.ToString(); }));
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            metaTrader4.MqlScope(mql => mql.OrderSend("EURUSD", ORDER_TYPE.OP_BUY, 1, mql.Ask(), 10, 0, 0));
        }

        private void SellButton_Click(object sender, RoutedEventArgs e)
        {
            metaTrader4.MqlScope(mql => mql.OrderSend("EURUSD", ORDER_TYPE.OP_SELL, 1, mql.Bid(), 10, 0, 0));
        }

        private void OrderClose_Click(object sender, RoutedEventArgs e)
        {
            DataGridRowAdd value = (DataGridRowAdd)DataGridOpen.SelectedItem;
            
            metaTrader4.MqlScope(mql =>
            {
                mql.OrderSelect(value.OrderTicket, SELECT_BY.SELECT_BY_TICKET);
                if (mql.OrderType() == ORDER_TYPE.OP_BUY)
                {
                    mql.OrderClose(value.OrderTicket, mql.OrderLots(), mql.Bid(), 3);
                }
                else
                {
                    mql.OrderClose(value.OrderTicket, mql.OrderLots(), mql.Ask(), 3);
                }
            });
        }

        public class DataGridRowAdd
        {
            public int OrderTicket { get; set; }
            public string Symbol { get; set; }
            public double Size { get; set; }
            public double Profit { get; set; }
        }
    }
}
