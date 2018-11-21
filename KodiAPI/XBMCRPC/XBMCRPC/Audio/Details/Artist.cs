using System.Collections.Generic;

namespace XBMCRPC.Audio.Details
{
   public class Artist : Base
   {
       public string artist { get; set; }
       public int artistid { get; set; }
       public string born { get; set; }
       public bool compilationartist { get; set; }
       public string description { get; set; }
       public string died { get; set; }
       public string disbanded { get; set; }
       public string formed { get; set; }
       public List<string> instrument { get; set; }
       public List<string> mood { get; set; }
       public string musicbrainzartistid { get; set; }
       public List<string> style { get; set; }
       public List<string> yearsactive { get; set; }
    }
}
