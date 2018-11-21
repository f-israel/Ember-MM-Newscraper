using System.Collections.Generic;

namespace XBMCRPC.Audio.Details
{
   public class Media : Base
   {
       public List<string> artist { get; set; }
       public List<int> artistid { get; set; }
       public string displayartist { get; set; }
       public List<int> genreid { get; set; }
       public string musicbrainzalbumartistid { get; set; }
       public string musicbrainzalbumid { get; set; }
       public int rating { get; set; }
       public string title { get; set; }
       public int year { get; set; }
    }
}
