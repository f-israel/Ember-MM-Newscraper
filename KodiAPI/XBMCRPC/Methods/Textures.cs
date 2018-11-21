using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.List.Filter;
using XBMCRPC.Textures;
using XBMCRPC.Textures.Fields;

namespace XBMCRPC.Methods
{
   public class Textures
   {
        private readonly Client _client;
          public Textures(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Retrieve all textures
                /// </summary>
        public async Task<GetTexturesResponse> GetTextures(TexturesAnd filter, Texture properties=null)
        {
            var jArgs = new JObject();
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetTexturesResponse>("Textures.GetTextures", jArgs);
        }

                /// <summary>
                /// Retrieve all textures
                /// </summary>
        public async Task<GetTexturesResponse> GetTextures(TexturesOr filter, Texture properties=null)
        {
            var jArgs = new JObject();
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetTexturesResponse>("Textures.GetTextures", jArgs);
        }

                /// <summary>
                /// Retrieve all textures
                /// </summary>
        public async Task<GetTexturesResponse> GetTextures(Rule.Textures filter, Texture properties=null)
        {
            var jArgs = new JObject();
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetTexturesResponse>("Textures.GetTextures", jArgs);
        }

                /// <summary>
                /// Retrieve all textures
                /// </summary>
        public async Task<GetTexturesResponse> GetTextures(Texture properties=null)
        {
            var jArgs = new JObject();
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetTexturesResponse>("Textures.GetTextures", jArgs);
        }

                /// <summary>
                /// Remove the specified texture
                /// </summary>
        public async Task<string> RemoveTexture(int textureid=0)
        {
            var jArgs = new JObject();
             if (textureid != null)
             {
                 var jproptextureid = JToken.FromObject(textureid, _client.Serializer);
                 jArgs.Add(new JProperty("textureid", jproptextureid));
             }
            return await _client.GetData<string>("Textures.RemoveTexture", jArgs);
        }
   }
}
