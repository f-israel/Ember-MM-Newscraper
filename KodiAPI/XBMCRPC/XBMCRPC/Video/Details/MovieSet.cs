using System.Collections.Generic;
using XBMCRPC.List;

namespace XBMCRPC.Video.Details
{
   public class MovieSet : Media
   {
       public int setid { get; set; }
   public class Extended : MovieSet
   {
       public LimitsReturned limits { get; set; }
       public List<Movie> movies { get; set; }
    }
    }
}
