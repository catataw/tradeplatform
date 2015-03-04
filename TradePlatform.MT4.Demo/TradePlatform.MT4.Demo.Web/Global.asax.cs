using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Exceptions;
using TradePlatform.MT4.Demo.Web;

namespace TradePlatform.MT4.Demo.Web
{
    public class Global : HttpApplication
    {
        public  MetaTrader4 metaTrader4;

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Bridge.InitializeHosts(true);

            metaTrader4 = Bridge.GetTerminal(121212, "EURUSD");
            metaTrader4.QuoteRecieved += metaTrader4_QuoteRecieved;
            metaTrader4.MqlError += metaTrader4_MqlError;
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        private void metaTrader4_MqlError(MqlErrorException mql)
        {
            // handler mql error
        }

        private void metaTrader4_QuoteRecieved(QuoteListener mql)
        {
            
        }
    }
}
