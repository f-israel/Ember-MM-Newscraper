using System.Collections.Generic;
using XBMCRPC.Item.Details;
using XBMCRPC.List;
using XBMCRPC.PVR.Channel;

namespace XBMCRPC.PVR.Details
{
   public class ChannelGroup : Base
   {
       public int channelgroupid { get; set; }
       public Type channeltype { get; set; }
   public class Extended : ChannelGroup
   {
       public List<Channel> channels { get; set; }
       public LimitsReturned limits { get; set; }
    }
    }
}
