using System.Collections.Generic;
using XBMCRPC.Library.Details;
using XBMCRPC.List;

namespace XBMCRPC.VideoLibrary
{
   public class GetGenresResponse
   {
       public List<Genre> genres { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
