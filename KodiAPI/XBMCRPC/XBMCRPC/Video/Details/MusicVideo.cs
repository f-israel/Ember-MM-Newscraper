using System.Collections.Generic;

namespace XBMCRPC.Video.Details
{
   public class MusicVideo : File
   {
       public string album { get; set; }
       public List<string> artist { get; set; }
       public List<string> genre { get; set; }
       public int musicvideoid { get; set; }
       public List<string> studio { get; set; }
       public List<string> tag { get; set; }
       public int track { get; set; }
       public int year { get; set; }
    }
}
