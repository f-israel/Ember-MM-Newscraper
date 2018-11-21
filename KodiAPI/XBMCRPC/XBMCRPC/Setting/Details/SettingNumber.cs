using Newtonsoft.Json;

namespace XBMCRPC.Setting.Details
{
   public class SettingNumber : SettingBase
   {
       [JsonProperty("default")]
       public double Default { get; set; }
       public double maximum { get; set; }
       public double minimum { get; set; }
       public double step { get; set; }
       public double value { get; set; }
    }
}
