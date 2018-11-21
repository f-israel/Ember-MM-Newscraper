using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.Video.Details;

namespace XBMCRPC.VideoLibrary
{
   public class GetRecentlyAddedMusicVideosResponse
   {
       public LimitsReturned limits { get; set; }
       public List<MusicVideo> musicvideos { get; set; }
    }
}
