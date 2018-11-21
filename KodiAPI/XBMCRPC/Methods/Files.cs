using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.Files;
using XBMCRPC.List;

namespace XBMCRPC.Methods
{
   public class Files
   {
        private readonly Client _client;
          public Files(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Get the directories and files in the given directory
                /// </summary>
        public async Task<GetDirectoryResponse> GetDirectory(string directory=null, XBMCRPC.Files.Media media=0, List.Fields.Files properties=null, Sort sort=null, Limits limits=null)
        {
            var jArgs = new JObject();
             if (directory != null)
             {
                 var jpropdirectory = JToken.FromObject(directory, _client.Serializer);
                 jArgs.Add(new JProperty("directory", jpropdirectory));
             }
             if (media != null)
             {
                 var jpropmedia = JToken.FromObject(media, _client.Serializer);
                 jArgs.Add(new JProperty("media", jpropmedia));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (sort != null)
             {
                 var jpropsort = JToken.FromObject(sort, _client.Serializer);
                 jArgs.Add(new JProperty("sort", jpropsort));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<GetDirectoryResponse>("Files.GetDirectory", jArgs);
        }

                /// <summary>
                /// Get details for a specific file
                /// </summary>
        public async Task<GetFileDetailsResponse> GetFileDetails(string file=null, XBMCRPC.Files.Media media=0, List.Fields.Files properties=null)
        {
            var jArgs = new JObject();
             if (file != null)
             {
                 var jpropfile = JToken.FromObject(file, _client.Serializer);
                 jArgs.Add(new JProperty("file", jpropfile));
             }
             if (media != null)
             {
                 var jpropmedia = JToken.FromObject(media, _client.Serializer);
                 jArgs.Add(new JProperty("media", jpropmedia));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetFileDetailsResponse>("Files.GetFileDetails", jArgs);
        }

                /// <summary>
                /// Get the sources of the media windows
                /// </summary>
        public async Task<GetSourcesResponse> GetSources(XBMCRPC.Files.Media media=0, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (media != null)
             {
                 var jpropmedia = JToken.FromObject(media, _client.Serializer);
                 jArgs.Add(new JProperty("media", jpropmedia));
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
            return await _client.GetData<GetSourcesResponse>("Files.GetSources", jArgs);
        }

                /// <summary>
                /// Provides a way to download a given file (e.g. providing an URL to the real file location)
                /// </summary>
        public async Task<PrepareDownloadResponse> PrepareDownload(string path=null)
        {
            var jArgs = new JObject();
             if (path != null)
             {
                 var jproppath = JToken.FromObject(path, _client.Serializer);
                 jArgs.Add(new JProperty("path", jproppath));
             }
            return await _client.GetData<PrepareDownloadResponse>("Files.PrepareDownload", jArgs);
        }
   }
}
