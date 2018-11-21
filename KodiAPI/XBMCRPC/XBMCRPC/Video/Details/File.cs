using System.Collections.Generic;

namespace XBMCRPC.Video.Details
{
   public class File : Item
   {
       public List<string> director { get; set; }
       public Resume resume { get; set; }
       public int runtime { get; set; }
       public Streams streamdetails { get; set; }
    }
}
