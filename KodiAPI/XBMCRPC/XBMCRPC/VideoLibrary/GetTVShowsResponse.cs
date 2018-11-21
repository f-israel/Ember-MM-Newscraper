using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.Video.Details;

namespace XBMCRPC.VideoLibrary
{
   public class GetTVShowsResponse
   {
       public LimitsReturned limits { get; set; }
       public List<TVShow> tvshows { get; set; }
    }
}
