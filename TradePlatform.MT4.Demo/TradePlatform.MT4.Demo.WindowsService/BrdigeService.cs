using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using TradePlatform.MT4.Core;

namespace TradePlatform.MT4.Demo.WindowsService
{
    public partial class BrdigeService : ServiceBase
    {
        public BrdigeService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Bridge.InitializeHosts();
        }

        protected override void OnStop()
        {

        }
    }
}
