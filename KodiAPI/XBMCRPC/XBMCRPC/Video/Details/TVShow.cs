using System.Collections.Generic;

namespace XBMCRPC.Video.Details
{
   public class TVShow : Item
   {
       public List<CastItem> cast { get; set; }
       public int episode { get; set; }
       public string episodeguide { get; set; }
       public List<string> genre { get; set; }
       public string imdbnumber { get; set; }
       public string mpaa { get; set; }
       public string originaltitle { get; set; }
       public string premiered { get; set; }
       public double rating { get; set; }
       public int season { get; set; }
       public string sorttitle { get; set; }
       public List<string> studio { get; set; }
       public List<string> tag { get; set; }
       public int tvshowid { get; set; }
       public string votes { get; set; }
       public int watchedepisodes { get; set; }
       public int year { get; set; }
    }
}
