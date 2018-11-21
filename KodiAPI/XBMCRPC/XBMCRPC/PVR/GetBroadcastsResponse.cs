using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.PVR.Details;

namespace XBMCRPC.PVR
{
   public class GetBroadcastsResponse
   {
       public List<Broadcast> broadcasts { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
