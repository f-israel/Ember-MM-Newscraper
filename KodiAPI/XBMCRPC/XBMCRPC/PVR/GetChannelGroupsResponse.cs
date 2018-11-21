using System.Collections.Generic;
using XBMCRPC.List;

namespace XBMCRPC.PVR
{
   public class GetChannelGroupsResponse
   {
       public List<Details.ChannelGroup> channelgroups { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
