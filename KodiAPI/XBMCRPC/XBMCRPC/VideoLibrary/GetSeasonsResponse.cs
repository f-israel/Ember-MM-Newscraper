using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.Video.Details;

namespace XBMCRPC.VideoLibrary
{
   public class GetSeasonsResponse
   {
       public LimitsReturned limits { get; set; }
       public List<Season> seasons { get; set; }
    }
}
