using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TradePlatform.MT4.Demo.WindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            ServiceBase[] servicesToRun = new ServiceBase[] 
                                              { 
                                                  new BrdigeService() 
                                              };

            if (Environment.UserInteractive)
            {
                Type type = typeof(ServiceBase);
                BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
                MethodInfo method = type.GetMethod("OnStart", flags);

                foreach (ServiceBase service in servicesToRun)
                {
                    method.Invoke(service, new object[] { args });
                }

                Console.WriteLine("Press any key to exit");
                Console.ReadLine();

                foreach (ServiceBase service in servicesToRun)
                {
                    service.Stop();
                }

            }
            else
            {
                ServiceBase.Run(servicesToRun);
            }
        }
    }
}
