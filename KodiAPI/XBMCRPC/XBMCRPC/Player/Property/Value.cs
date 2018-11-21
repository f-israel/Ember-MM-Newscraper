using System.Collections.Generic;
using XBMCRPC.Global;
using XBMCRPC.Player.Audio;

namespace XBMCRPC.Player.Property
{
   public class Value
   {
       public List<Stream> audiostreams { get; set; }
       public bool canchangespeed { get; set; }
       public bool canmove { get; set; }
       public bool canrepeat { get; set; }
       public bool canrotate { get; set; }
       public bool canseek { get; set; }
       public bool canshuffle { get; set; }
       public bool canzoom { get; set; }
       public Stream currentaudiostream { get; set; }
       public Subtitle currentsubtitle { get; set; }
       public bool live { get; set; }
       public bool partymode { get; set; }
       public double percentage { get; set; }
       public int playlistid { get; set; }
       public int position { get; set; }
       public Repeat repeat { get; set; }
       public bool shuffled { get; set; }
       public int speed { get; set; }
       public bool subtitleenabled { get; set; }
       public List<Subtitle> subtitles { get; set; }
       public Time time { get; set; }
       public Time totaltime { get; set; }
       public Type type { get; set; }
    }
}
