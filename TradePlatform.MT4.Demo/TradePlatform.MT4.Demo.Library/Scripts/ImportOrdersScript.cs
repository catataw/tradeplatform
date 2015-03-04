using System.Collections.Generic;
using System.Linq;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Data;
using TradePlatform.MT4.SDK.API;

namespace TradePlatform.MT4.Demo.Library.Scripts
{
    public class ImportOrdersScript : ExpertAdvisor
    {
        protected override int Init()
        {

            return 1;
        }

        protected override int Start()
        {
            using (TradePlatformEntities model = new TradePlatformEntities())
            {
                int currentNumber = this.AccountNumber();
                MetaTraderAccount account = model.MetaTraderAccounts.SingleOrDefault(x => x.AccountNumber == currentNumber);

                if (account == null)
                {
                    account = new MetaTraderAccount();
                    model.MetaTraderAccounts.AddObject(account);
                }

                account.AccountBalance = (decimal) this.AccountBalance();
                account.AccountCredit = this.AccountCredit();
                account.AccountCompany = this.AccountCompany();
                account.AccountCurrency = this.AccountCurrency();
                account.AccountEquity = (decimal)this.AccountEquity();
                account.AccountFreeMargin = (decimal)this.AccountFreeMargin();
                account.AccountFreeMarginMode = this.AccountFreeMarginMode();
                account.AccountLeverage = this.AccountLeverage();
                account.AccountMargin = (decimal)this.AccountMargin();
                account.AccountName = this.AccountName();
                account.AccountNumber = this.AccountNumber();
                account.AccountProfit = (decimal)this.AccountProfit();
                account.AccountServer = this.AccountServer();
                account.AccountStopoutLevel = this.AccountStopoutLevel();
                account.AccountStopoutMode = this.AccountStopoutMode();

                List<MetaTraderOrder> openedOrders = account.MetaTraderOrders.Where(x => x.IsClosed == false).ToList();

                openedOrders.ForEach(x => model.MetaTraderOrders.DeleteObject(x));

                for (int i = this.OrdersTotal() - 1; i >= 0; i--)
                {
                    if (this.OrderSelect(i, SELECT_BY.SELECT_BY_POS, POOL_MODES.MODE_TRADES))
                    {
                        MetaTraderOrder order = new MetaTraderOrder();
  
                        order.ClosePrice = this.OrderClosePrice();
                        order.CloseTime = this.OrderCloseTime();
                        order.Comment = this.OrderComment();
                        order.Ticket = this.OrderTicket();
                        order.OpenPrice = this.OrderOpenPrice();
                        order.OpenTime = this.OrderOpenTime();
                        order.Profit = (decimal)this.OrderProfit();
                        order.Size = this.OrderLots();
                        order.StopLoss = this.OrderStopLoss();
                        order.Swap = (decimal)this.OrderSwap();
                        order.Symbol = this.OrderSymbol();
                        order.TakeProfit = this.OrderTakeProfit();
                        order.Type = this.OrderType().ToString();
                        order.MagicNumber = this.OrderMagicNumber();
                        order.Commission = (decimal)this.OrderCommission();
                        order.IsClosed = false;

                        account.MetaTraderOrders.Add(order);
                    }
                }

                List<int> list = account.MetaTraderOrders.Select(order => order.Ticket).ToList();

                for (int i = this.HistoryTotal() - 1; i >= 0; i--)
                {
                    if (this.OrderSelect(i, SELECT_BY.SELECT_BY_POS, POOL_MODES.MODE_HISTORY))
                    {
                        if (!list.Contains(this.OrderTicket()))
                        {
                            MetaTraderOrder order = new MetaTraderOrder();
                            order.ClosePrice = this.OrderClosePrice();
                            order.CloseTime = this.OrderCloseTime();
                            order.Comment = this.OrderComment();
                            order.Ticket = this.OrderTicket();
                            order.OpenPrice = this.OrderOpenPrice();
                            order.OpenTime = this.OrderOpenTime();
                            order.Profit = (decimal)this.OrderProfit();
                            order.Size = this.OrderLots();
                            order.StopLoss = this.OrderStopLoss();
                            order.Swap = (decimal)this.OrderSwap();
                            order.Symbol = this.OrderSymbol();
                            order.TakeProfit = this.OrderTakeProfit();
                            order.Type = this.OrderType().ToString();
                            order.MagicNumber = this.OrderMagicNumber();
                            order.Commission = (decimal)this.OrderCommission();
                            order.IsClosed = true;

                            account.MetaTraderOrders.Add(order);
                        }
                    }
                }

                model.SaveChanges();
            }

            return 1;
        }

        protected override int DeInit()
        {
            return 1;
        }
    }
}
