using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.List.Item;

namespace XBMCRPC.Playlist
{
   public class GetItemsResponse
   {
       public List<All> items { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
