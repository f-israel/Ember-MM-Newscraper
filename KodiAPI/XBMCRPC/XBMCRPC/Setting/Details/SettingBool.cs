using Newtonsoft.Json;

namespace XBMCRPC.Setting.Details
{
   public class SettingBool : SettingBase
   {
       [JsonProperty("default")]
       public bool Default { get; set; }
       public bool value { get; set; }
    }
}
