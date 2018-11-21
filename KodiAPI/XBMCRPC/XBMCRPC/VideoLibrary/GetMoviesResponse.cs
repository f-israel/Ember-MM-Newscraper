using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.Video.Details;

namespace XBMCRPC.VideoLibrary
{
   public class GetMoviesResponse
   {
       public LimitsReturned limits { get; set; }
       public List<Movie> movies { get; set; }
    }
}
