using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePlatform.MT4.SDK.API
{
    using TradePlatform.MT4.Core;
    using TradePlatform.MT4.Core.Utils;
    using TradePlatform.MT4.SDK.API.Constants;

    public static class Checkup
    {
        /// <summary>
        /// The function returns the last occurred error
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static string GetLastError(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("GetLastError");

            return retrunValue;
        }

        /// <summary>
        /// The function returns the status of the main connection between client terminal and server that performs data pumping.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsConnected(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsConnected");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if the expert runs on a demo account, otherwise returns FALSE. 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsDemo(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsDemo");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if the function DLL call is allowed for the expert, otherwise returns FALSE.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsDllsAllowed(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsDllsAllowed");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if expert adwisors are enabled for running, otherwise returns FALSE. 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsExpertEnabled(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsExpertEnabled");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if the expert can call library function, otherwise returns FALSE. 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsLibrariesAllowed(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsLibrariesAllowed");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if expert runs in the strategy tester optimization mode, otherwise returns FALSE. 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsOptimization(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsOptimization");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if the program (an expert or a script) has been commanded to stop its operation, otherwise returns FALSE. 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsStopped(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsStopped");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if expert runs in the testing mode, otherwise returns FALSE. 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsTesting(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsTesting");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if the expert is allowed to trade and a thread for trading is not occupied, otherwise returns FALSE.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsTradeAllowed(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsTradeAllowed");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if a thread for trading is occupied by another expert advisor, otherwise returns FALSE.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsTradeContextBusy(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsTradeContextBusy");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns TRUE if the expert is tested with checked "Visual Mode" button, otherwise returns FALSE. 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool IsVisualMode(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IsVisualMode");

            return Convertor.ToBoolean(retrunValue);
        }

        /// <summary>
        /// Returns the code of the uninitialization reason for the experts, custom indicators, and scripts. 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static UNINITIALIZE_REASON UninitializeReason(this MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("UninitializeReason");

            return (UNINITIALIZE_REASON)Enum.Parse(typeof(UNINITIALIZE_REASON), retrunValue);
        }
    }
}