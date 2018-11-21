using System.Collections.Generic;

namespace XBMCRPC.Audio.Details
{
   public class Song : Media
   {
       public string album { get; set; }
       public List<string> albumartist { get; set; }
       public List<int> albumartistid { get; set; }
       public int albumid { get; set; }
       public string comment { get; set; }
       public int disc { get; set; }
       public int duration { get; set; }
       public string file { get; set; }
       public string lastplayed { get; set; }
       public string lyrics { get; set; }
       public string musicbrainzartistid { get; set; }
       public string musicbrainztrackid { get; set; }
       public int playcount { get; set; }
       public int songid { get; set; }
       public int track { get; set; }
    }
}
