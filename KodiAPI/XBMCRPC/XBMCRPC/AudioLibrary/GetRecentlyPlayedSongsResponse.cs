using System.Collections.Generic;
using XBMCRPC.Audio.Details;
using XBMCRPC.List;

namespace XBMCRPC.AudioLibrary
{
   public class GetRecentlyPlayedSongsResponse
   {
       public LimitsReturned limits { get; set; }
       public List<Song> songs { get; set; }
    }
}
