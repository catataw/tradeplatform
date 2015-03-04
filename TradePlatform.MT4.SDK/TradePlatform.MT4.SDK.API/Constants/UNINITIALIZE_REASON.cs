using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePlatform.MT4.SDK.API
{
    public enum UNINITIALIZE_REASON : int
    {
        REASON_NO = 0,
        REASON_REMOVE = 1,
        REASON_RECOMPILE = 2,
        REASON_CHARTCHANGE = 3,
        REASON_CHARTCLOSE = 4,
        REASON_PARAMETERS = 5,
        REASON_ACCOUNT = 6
    }
}
