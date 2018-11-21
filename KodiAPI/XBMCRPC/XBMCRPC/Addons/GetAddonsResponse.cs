using System.Collections.Generic;
using XBMCRPC.Addon;
using XBMCRPC.List;

namespace XBMCRPC.Addons
{
   public class GetAddonsResponse
   {
       public List<Details> addons { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
