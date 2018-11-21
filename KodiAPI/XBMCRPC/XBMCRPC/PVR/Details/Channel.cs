using XBMCRPC.Item.Details;
using XBMCRPC.PVR.Channel;

namespace XBMCRPC.PVR.Details
{
   public class Channel : Base
   {
       public string channel { get; set; }
       public int channelid { get; set; }
       public Type channeltype { get; set; }
       public bool hidden { get; set; }
       public string lastplayed { get; set; }
       public bool locked { get; set; }
       public string thumbnail { get; set; }
    }
}
