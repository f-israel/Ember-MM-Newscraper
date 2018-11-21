using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.List;
using XBMCRPC.Profiles;
using XBMCRPC.Profiles.Details;

namespace XBMCRPC.Methods
{
   public class Profiles
   {
        private readonly Client _client;
          public Profiles(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Retrieve the current profile
                /// </summary>
        public async Task<Profile> GetCurrentProfile(XBMCRPC.Profiles.Fields.Profile properties=null)
        {
            var jArgs = new JObject();
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<Profile>("Profiles.GetCurrentProfile", jArgs);
        }

                /// <summary>
                /// Retrieve all profiles
                /// </summary>
        public async Task<GetProfilesResponse> GetProfiles(XBMCRPC.Profiles.Fields.Profile properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
             if (sort != null)
             {
                 var jpropsort = JToken.FromObject(sort, _client.Serializer);
                 jArgs.Add(new JProperty("sort", jpropsort));
             }
            return await _client.GetData<GetProfilesResponse>("Profiles.GetProfiles", jArgs);
        }

                /// <summary>
                /// Load the specified profile
                /// </summary>
        public async Task<string> LoadProfile(string profile=null, bool prompt=false, Password password=null)
        {
            var jArgs = new JObject();
             if (profile != null)
             {
                 var jpropprofile = JToken.FromObject(profile, _client.Serializer);
                 jArgs.Add(new JProperty("profile", jpropprofile));
             }
             if (prompt != null)
             {
                 var jpropprompt = JToken.FromObject(prompt, _client.Serializer);
                 jArgs.Add(new JProperty("prompt", jpropprompt));
             }
             if (password != null)
             {
                 var jproppassword = JToken.FromObject(password, _client.Serializer);
                 jArgs.Add(new JProperty("password", jproppassword));
             }
            return await _client.GetData<string>("Profiles.LoadProfile", jArgs);
        }
   }
}
