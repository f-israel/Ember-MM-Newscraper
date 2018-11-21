using System.Collections.Generic;
using Newtonsoft.Json;

namespace XBMCRPC.Setting.Details
{
   public class SettingList : SettingBase
   {
       [JsonProperty("default")]
       public List<object> Default { get; set; }
       public object definition { get; set; }
       public string delimiter { get; set; }
       public Type elementtype { get; set; }
       public int maximumitems { get; set; }
       public int minimumitems { get; set; }
       public List<object> value { get; set; }
    }
}
