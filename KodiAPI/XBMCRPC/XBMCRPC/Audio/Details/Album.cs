using System.Collections.Generic;

namespace XBMCRPC.Audio.Details
{
   public class Album : Media
   {
       public int albumid { get; set; }
       public string albumlabel { get; set; }
       public string description { get; set; }
       public List<string> mood { get; set; }
       public int playcount { get; set; }
       public List<string> style { get; set; }
       public List<string> theme { get; set; }
       public string type { get; set; }
    }
}
