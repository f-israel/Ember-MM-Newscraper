using System.Collections.Generic;
using XBMCRPC.List;

namespace XBMCRPC.Favourites
{
   public class GetFavouritesResponse
   {
       public List<Favourite.Details.Favourite> favourites { get; set; }
       public LimitsReturned limits { get; set; }
    }
}
