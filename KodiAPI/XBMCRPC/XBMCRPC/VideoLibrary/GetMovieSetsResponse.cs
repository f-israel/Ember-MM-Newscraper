using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.Video.Details;

namespace XBMCRPC.VideoLibrary
{
   public class GetMovieSetsResponse
   {
       public LimitsReturned limits { get; set; }
       public List<MovieSet> sets { get; set; }
    }
}
