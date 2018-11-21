using System.Collections.Generic;
using XBMCRPC.List;

namespace XBMCRPC.PVR
{
   public class GetChannelsResponse
   {
       public List<Details.Channel> channels { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
