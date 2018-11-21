using XBMCRPC.Addon;
using XBMCRPC.List;

namespace XBMCRPC.Addons
{
   public class GetAddonDetailsResponse
   {
       public Details addon { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
