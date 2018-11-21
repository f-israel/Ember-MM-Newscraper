using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.JSONRPC;

namespace XBMCRPC.Methods
{
   public class JSONRPC
   {
        private readonly Client _client;
          public JSONRPC(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Enumerates all actions and descriptions
                /// </summary>
        public async Task<IntrospectResponse> Introspect(bool getdescriptions=false, bool getmetadata=false, bool filterbytransport=false, Introspect_filter filter=null)
        {
            var jArgs = new JObject();
             if (getdescriptions != null)
             {
                 var jpropgetdescriptions = JToken.FromObject(getdescriptions, _client.Serializer);
                 jArgs.Add(new JProperty("getdescriptions", jpropgetdescriptions));
             }
             if (getmetadata != null)
             {
                 var jpropgetmetadata = JToken.FromObject(getmetadata, _client.Serializer);
                 jArgs.Add(new JProperty("getmetadata", jpropgetmetadata));
             }
             if (filterbytransport != null)
             {
                 var jpropfilterbytransport = JToken.FromObject(filterbytransport, _client.Serializer);
                 jArgs.Add(new JProperty("filterbytransport", jpropfilterbytransport));
             }
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<IntrospectResponse>("JSONRPC.Introspect", jArgs);
        }

                /// <summary>
                /// Notify all other connected clients
                /// </summary>
        public async Task<object> NotifyAll(string sender=null, string message=null, object data=null)
        {
            var jArgs = new JObject();
             if (sender != null)
             {
                 var jpropsender = JToken.FromObject(sender, _client.Serializer);
                 jArgs.Add(new JProperty("sender", jpropsender));
             }
             if (message != null)
             {
                 var jpropmessage = JToken.FromObject(message, _client.Serializer);
                 jArgs.Add(new JProperty("message", jpropmessage));
             }
             if (data != null)
             {
                 var jpropdata = JToken.FromObject(data, _client.Serializer);
                 jArgs.Add(new JProperty("data", jpropdata));
             }
            return await _client.GetData<object>("JSONRPC.NotifyAll", jArgs);
        }

                /// <summary>
                /// Retrieve the clients permissions
                /// </summary>
        public async Task<PermissionResponse> Permission()
        {
            var jArgs = new JObject();
            return await _client.GetData<PermissionResponse>("JSONRPC.Permission", jArgs);
        }

                /// <summary>
                /// Ping responder
                /// </summary>
        public async Task<string> Ping()
        {
            var jArgs = new JObject();
            return await _client.GetData<string>("JSONRPC.Ping", jArgs);
        }

                /// <summary>
                /// Retrieve the JSON-RPC protocol version.
                /// </summary>
        public async Task<VersionResponse> Version()
        {
            var jArgs = new JObject();
            return await _client.GetData<VersionResponse>("JSONRPC.Version", jArgs);
        }
   }
}
