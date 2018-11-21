using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.List.Items;

namespace XBMCRPC.Files
{
   public class GetSourcesResponse
   {
       public LimitsReturned limits { get; set; }
       public List<SourcesItem> sources { get; set; }
    }
}
