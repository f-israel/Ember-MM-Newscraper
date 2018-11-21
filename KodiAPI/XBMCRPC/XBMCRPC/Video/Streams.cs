using System.Collections.Generic;

namespace XBMCRPC.Video
{
   public class Streams
   {
       public List<Streams_audioItem> audio { get; set; }
       public List<Streams_subtitleItem> subtitle { get; set; }
       public List<Streams_videoItem> video { get; set; }
    }
}
