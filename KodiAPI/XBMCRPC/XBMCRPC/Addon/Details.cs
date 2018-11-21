using System.Collections.Generic;
using XBMCRPC.Item.Details;

namespace XBMCRPC.Addon
{
   public class Details : Base
   {
       public string addonid { get; set; }
       public string author { get; set; }
       public string broken { get; set; }
       public List<Details_dependenciesItem> dependencies { get; set; }
       public string description { get; set; }
       public string disclaimer { get; set; }
       public bool enabled { get; set; }
       public List<Details_extrainfoItem> extrainfo { get; set; }
       public string fanart { get; set; }
       public string name { get; set; }
       public string path { get; set; }
       public int rating { get; set; }
       public string summary { get; set; }
       public string thumbnail { get; set; }
       public Types type { get; set; }
       public string version { get; set; }
    }
}
