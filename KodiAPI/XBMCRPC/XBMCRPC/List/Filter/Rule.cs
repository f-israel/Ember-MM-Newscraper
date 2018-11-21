using Newtonsoft.Json;

namespace XBMCRPC.List.Filter
{
   public class Rule
   {
       [JsonProperty("operator")]
       public Operators Operator { get; set; }
       public object value { get; set; }
   public class Albums : Rule
   {
       public Fields.Albums field { get; set; }
    }
   public class Artists : Rule
   {
       public Fields.Artists field { get; set; }
    }
   public class Episodes : Rule
   {
       public Fields.Episodes field { get; set; }
    }
   public class Movies : Rule
   {
       public Fields.Movies field { get; set; }
    }
   public class MusicVideos : Rule
   {
       public Fields.MusicVideos field { get; set; }
    }
   public class Songs : Rule
   {
       public Fields.Songs field { get; set; }
    }
   public class TVShows : Rule
   {
       public Fields.TVShows field { get; set; }
    }
   public class Textures : Rule
   {
       public Fields.Textures field { get; set; }
    }
    }
}
