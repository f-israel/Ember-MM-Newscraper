using XBMCRPC.List;
using XBMCRPC.Video.Fields;

namespace XBMCRPC.VideoLibrary
{
   public class GetMovieSetDetails_movies
   {
       public Limits limits { get; set; }
       public Movie properties { get; set; }
       public Sort sort { get; set; }
    }
}
