using System.Collections.Generic;
using Newtonsoft.Json;

namespace XBMCRPC.Setting.Details
{
   public class SettingString : SettingBase
   {
       public bool allowempty { get; set; }
       [JsonProperty("default")]
       public string Default { get; set; }
       public List<SettingString_optionsItem> options { get; set; }
       public string value { get; set; }
    }
}
