using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.XBMC;

namespace XBMCRPC.Methods
{
   public class XBMC
   {
        private readonly Client _client;
          public XBMC(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Retrieve info booleans about XBMC and the system
                /// </summary>
        public async Task<GetInfoBooleansResponse> GetInfoBooleans(List<string> booleans=null)
        {
            var jArgs = new JObject();
             if (booleans != null)
             {
                 var jpropbooleans = JToken.FromObject(booleans, _client.Serializer);
                 jArgs.Add(new JProperty("booleans", jpropbooleans));
             }
            return await _client.GetData<GetInfoBooleansResponse>("XBMC.GetInfoBooleans", jArgs);
        }

                /// <summary>
                /// Retrieve info labels about XBMC and the system
                /// </summary>
        public async Task<GetInfoLabelsResponse> GetInfoLabels(List<string> labels=null)
        {
            var jArgs = new JObject();
             if (labels != null)
             {
                 var jproplabels = JToken.FromObject(labels, _client.Serializer);
                 jArgs.Add(new JProperty("labels", jproplabels));
             }
            return await _client.GetData<GetInfoLabelsResponse>("XBMC.GetInfoLabels", jArgs);
        }
   }
}
