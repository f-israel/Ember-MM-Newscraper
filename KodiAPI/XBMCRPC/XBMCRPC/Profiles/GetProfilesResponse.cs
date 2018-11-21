using System.Collections.Generic;
using XBMCRPC.List;
using XBMCRPC.Profiles.Details;

namespace XBMCRPC.Profiles
{
   public class GetProfilesResponse
   {
       public LimitsReturned limits { get; set; }
       public List<Profile> profiles { get; set; }
    }
}
