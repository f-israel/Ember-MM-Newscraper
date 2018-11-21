using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.Favourite;
using XBMCRPC.Favourites;

namespace XBMCRPC.Methods
{
   public class Favourites
   {
        private readonly Client _client;
          public Favourites(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Add a favourite with the given details
                /// </summary>
        public async Task<string> AddFavourite(string title=null, Type type=0, string path=null, string window=null, string windowparameter=null, string thumbnail=null)
        {
            var jArgs = new JObject();
             if (title != null)
             {
                 var jproptitle = JToken.FromObject(title, _client.Serializer);
                 jArgs.Add(new JProperty("title", jproptitle));
             }
             if (type != null)
             {
                 var jproptype = JToken.FromObject(type, _client.Serializer);
                 jArgs.Add(new JProperty("type", jproptype));
             }
             if (path != null)
             {
                 var jproppath = JToken.FromObject(path, _client.Serializer);
                 jArgs.Add(new JProperty("path", jproppath));
             }
             if (window != null)
             {
                 var jpropwindow = JToken.FromObject(window, _client.Serializer);
                 jArgs.Add(new JProperty("window", jpropwindow));
             }
             if (windowparameter != null)
             {
                 var jpropwindowparameter = JToken.FromObject(windowparameter, _client.Serializer);
                 jArgs.Add(new JProperty("windowparameter", jpropwindowparameter));
             }
             if (thumbnail != null)
             {
                 var jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                 jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
             }
            return await _client.GetData<string>("Favourites.AddFavourite", jArgs);
        }

                /// <summary>
                /// Retrieve all favourites
                /// </summary>
        public async Task<GetFavouritesResponse> GetFavourites(Type type=0, Favourite.Fields.Favourite properties=null)
        {
            var jArgs = new JObject();
             if (type != null)
             {
                 var jproptype = JToken.FromObject(type, _client.Serializer);
                 jArgs.Add(new JProperty("type", jproptype));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetFavouritesResponse>("Favourites.GetFavourites", jArgs);
        }
   }
}
