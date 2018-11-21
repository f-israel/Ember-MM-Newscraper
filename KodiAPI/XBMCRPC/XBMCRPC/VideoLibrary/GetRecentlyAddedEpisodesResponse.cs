using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.Video.Details;

namespace XBMCRPC.VideoLibrary
{
   public class GetRecentlyAddedEpisodesResponse
   {
       public List<Episode> episodes { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
