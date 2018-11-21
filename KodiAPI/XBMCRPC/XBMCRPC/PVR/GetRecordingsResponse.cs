using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.PVR.Details;

namespace XBMCRPC.PVR
{
   public class GetRecordingsResponse
   {
       public LimitsReturned limits { get; set; }
       public List<Recording> recordings { get; set; }
    }
}
