using System.Collections.Generic;
using XBMCRPC.Audio.Details;
using XBMCRPC.List;

namespace XBMCRPC.AudioLibrary
{
   public class GetArtistsResponse
   {
       public List<Artist> artists { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
