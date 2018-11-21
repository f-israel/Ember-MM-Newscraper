using System.Collections.Generic;
using XBMCRPC.Audio.Details;
using XBMCRPC.List;

namespace XBMCRPC.AudioLibrary
{
   public class GetRecentlyAddedSongsResponse
   {
       public LimitsReturned limits { get; set; }
       public List<Song> songs { get; set; }
    }
}
