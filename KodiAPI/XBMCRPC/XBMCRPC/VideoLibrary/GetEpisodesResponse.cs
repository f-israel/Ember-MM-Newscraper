using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.Video.Details;

namespace XBMCRPC.VideoLibrary
{
   public class GetEpisodesResponse
   {
       public List<Episode> episodes { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
