using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.List.Item;

namespace XBMCRPC.Files
{
   public class GetDirectoryResponse
   {
       public List<File> files { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
