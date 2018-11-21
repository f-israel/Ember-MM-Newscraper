using Newtonsoft.Json;

namespace XBMCRPC.XBMC
{
    public class GetInfoBooleansResponse
    {
        [JsonProperty(PropertyName = "Library.IsScanningVideo")]
        public bool IsScanningVideo { get; set; }
    }
}
