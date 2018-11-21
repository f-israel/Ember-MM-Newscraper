using XBMCRPC.Media;

namespace XBMCRPC.Video.Details
{
   public class Base : XBMCRPC.Media.Details.Base
   {
       public Artwork art { get; set; }
       public int playcount { get; set; }
    }
}
