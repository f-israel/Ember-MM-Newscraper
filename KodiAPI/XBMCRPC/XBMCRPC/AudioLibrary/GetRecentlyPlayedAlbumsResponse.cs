using System.Collections.Generic;
using XBMCRPC.Audio.Details;
using XBMCRPC.List;

namespace XBMCRPC.AudioLibrary
{
   public class GetRecentlyPlayedAlbumsResponse
   {
       public List<Album> albums { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
