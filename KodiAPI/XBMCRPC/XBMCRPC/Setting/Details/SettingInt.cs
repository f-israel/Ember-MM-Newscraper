using System.Collections.Generic;
using Newtonsoft.Json;

namespace XBMCRPC.Setting.Details
{
   public class SettingInt : SettingBase
   {
       [JsonProperty("default")]
       public int Default { get; set; }
       public int maximum { get; set; }
       public int minimum { get; set; }
       public List<SettingInt_optionsItem> options { get; set; }
       public int step { get; set; }
       public int value { get; set; }
    }
}
