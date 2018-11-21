using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.PVR.Details;

namespace XBMCRPC.PVR
{
   public class GetTimersResponse
   {
       public LimitsReturned limits { get; set; }
       public List<Timer> timers { get; set; }
    }
}
