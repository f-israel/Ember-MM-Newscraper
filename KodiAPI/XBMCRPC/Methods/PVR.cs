using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.Global;
using XBMCRPC.List;
using XBMCRPC.PVR;
using XBMCRPC.PVR.Channel;
using XBMCRPC.PVR.ChannelGroup;
using XBMCRPC.PVR.Fields;
using XBMCRPC.PVR.Property;

namespace XBMCRPC.Methods
{
   public class PVR
   {
        private readonly Client _client;
          public PVR(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Retrieves the details of a specific broadcast
                /// </summary>
        public async Task<GetBroadcastDetailsResponse> GetBroadcastDetails(int broadcastid=0, Broadcast properties=null)
        {
            var jArgs = new JObject();
             if (broadcastid != null)
             {
                 var jpropbroadcastid = JToken.FromObject(broadcastid, _client.Serializer);
                 jArgs.Add(new JProperty("broadcastid", jpropbroadcastid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetBroadcastDetailsResponse>("PVR.GetBroadcastDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the program of a specific channel
                /// </summary>
        public async Task<GetBroadcastsResponse> GetBroadcasts(int channelid=0, Broadcast properties=null, Limits limits=null)
        {
            var jArgs = new JObject();
             if (channelid != null)
             {
                 var jpropchannelid = JToken.FromObject(channelid, _client.Serializer);
                 jArgs.Add(new JProperty("channelid", jpropchannelid));
             }
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
            return await _client.GetData<GetBroadcastsResponse>("PVR.GetBroadcasts", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific channel
                /// </summary>
        public async Task<GetChannelDetailsResponse> GetChannelDetails(int channelid=0, Channel properties=null)
        {
            var jArgs = new JObject();
             if (channelid != null)
             {
                 var jpropchannelid = JToken.FromObject(channelid, _client.Serializer);
                 jArgs.Add(new JProperty("channelid", jpropchannelid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetChannelDetailsResponse>("PVR.GetChannelDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific channel group
                /// </summary>
        public async Task<GetChannelGroupDetailsResponse> GetChannelGroupDetails(int channelgroupid, GetChannelGroupDetails_channels channels=null)
        {
            var jArgs = new JObject();
             if (channelgroupid != null)
             {
                 var jpropchannelgroupid = JToken.FromObject(channelgroupid, _client.Serializer);
                 jArgs.Add(new JProperty("channelgroupid", jpropchannelgroupid));
             }
             if (channels != null)
             {
                 var jpropchannels = JToken.FromObject(channels, _client.Serializer);
                 jArgs.Add(new JProperty("channels", jpropchannels));
             }
            return await _client.GetData<GetChannelGroupDetailsResponse>("PVR.GetChannelGroupDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific channel group
                /// </summary>
        public async Task<GetChannelGroupDetailsResponse> GetChannelGroupDetails(Id1 channelgroupid, GetChannelGroupDetails_channels channels=null)
        {
            var jArgs = new JObject();
             if (channelgroupid != null)
             {
                 var jpropchannelgroupid = JToken.FromObject(channelgroupid, _client.Serializer);
                 jArgs.Add(new JProperty("channelgroupid", jpropchannelgroupid));
             }
             if (channels != null)
             {
                 var jpropchannels = JToken.FromObject(channels, _client.Serializer);
                 jArgs.Add(new JProperty("channels", jpropchannels));
             }
            return await _client.GetData<GetChannelGroupDetailsResponse>("PVR.GetChannelGroupDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific channel group
                /// </summary>
        public async Task<GetChannelGroupDetailsResponse> GetChannelGroupDetails(GetChannelGroupDetails_channels channels=null)
        {
            var jArgs = new JObject();
             if (channels != null)
             {
                 var jpropchannels = JToken.FromObject(channels, _client.Serializer);
                 jArgs.Add(new JProperty("channels", jpropchannels));
             }
            return await _client.GetData<GetChannelGroupDetailsResponse>("PVR.GetChannelGroupDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the channel groups for the specified type
                /// </summary>
        public async Task<GetChannelGroupsResponse> GetChannelGroups(Type channeltype=0, Limits limits=null)
        {
            var jArgs = new JObject();
             if (channeltype != null)
             {
                 var jpropchanneltype = JToken.FromObject(channeltype, _client.Serializer);
                 jArgs.Add(new JProperty("channeltype", jpropchanneltype));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<GetChannelGroupsResponse>("PVR.GetChannelGroups", jArgs);
        }

                /// <summary>
                /// Retrieves the channel list
                /// </summary>
        public async Task<GetChannelsResponse> GetChannels(int channelgroupid, Channel properties=null, Limits limits=null)
        {
            var jArgs = new JObject();
             if (channelgroupid != null)
             {
                 var jpropchannelgroupid = JToken.FromObject(channelgroupid, _client.Serializer);
                 jArgs.Add(new JProperty("channelgroupid", jpropchannelgroupid));
             }
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
            return await _client.GetData<GetChannelsResponse>("PVR.GetChannels", jArgs);
        }

                /// <summary>
                /// Retrieves the channel list
                /// </summary>
        public async Task<GetChannelsResponse> GetChannels(Id1 channelgroupid, Channel properties=null, Limits limits=null)
        {
            var jArgs = new JObject();
             if (channelgroupid != null)
             {
                 var jpropchannelgroupid = JToken.FromObject(channelgroupid, _client.Serializer);
                 jArgs.Add(new JProperty("channelgroupid", jpropchannelgroupid));
             }
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
            return await _client.GetData<GetChannelsResponse>("PVR.GetChannels", jArgs);
        }

                /// <summary>
                /// Retrieves the channel list
                /// </summary>
        public async Task<GetChannelsResponse> GetChannels(Channel properties=null, Limits limits=null)
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
            return await _client.GetData<GetChannelsResponse>("PVR.GetChannels", jArgs);
        }

                /// <summary>
                /// Retrieves the values of the given properties
                /// </summary>
        public async Task<Value> GetProperties(GetProperties_properties properties=null)
        {
            var jArgs = new JObject();
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<Value>("PVR.GetProperties", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific recording
                /// </summary>
        public async Task<GetRecordingDetailsResponse> GetRecordingDetails(int recordingid=0, Recording properties=null)
        {
            var jArgs = new JObject();
             if (recordingid != null)
             {
                 var jproprecordingid = JToken.FromObject(recordingid, _client.Serializer);
                 jArgs.Add(new JProperty("recordingid", jproprecordingid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetRecordingDetailsResponse>("PVR.GetRecordingDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the recordings
                /// </summary>
        public async Task<GetRecordingsResponse> GetRecordings(Recording properties=null, Limits limits=null)
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
            return await _client.GetData<GetRecordingsResponse>("PVR.GetRecordings", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific timer
                /// </summary>
        public async Task<GetTimerDetailsResponse> GetTimerDetails(int timerid=0, Timer properties=null)
        {
            var jArgs = new JObject();
             if (timerid != null)
             {
                 var jproptimerid = JToken.FromObject(timerid, _client.Serializer);
                 jArgs.Add(new JProperty("timerid", jproptimerid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetTimerDetailsResponse>("PVR.GetTimerDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the timers
                /// </summary>
        public async Task<GetTimersResponse> GetTimers(Timer properties=null, Limits limits=null)
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
            return await _client.GetData<GetTimersResponse>("PVR.GetTimers", jArgs);
        }

                /// <summary>
                /// Toggle recording of a channel
                /// </summary>
        public async Task<string> Record(bool record, object channel=null)
        {
            var jArgs = new JObject();
             if (record != null)
             {
                 var jproprecord = JToken.FromObject(record, _client.Serializer);
                 jArgs.Add(new JProperty("record", jproprecord));
             }
             if (channel != null)
             {
                 var jpropchannel = JToken.FromObject(channel, _client.Serializer);
                 jArgs.Add(new JProperty("channel", jpropchannel));
             }
            return await _client.GetData<string>("PVR.Record", jArgs);
        }

                /// <summary>
                /// Toggle recording of a channel
                /// </summary>
        public async Task<string> Record(Toggle2 record, object channel=null)
        {
            var jArgs = new JObject();
             if (record != null)
             {
                 var jproprecord = JToken.FromObject(record, _client.Serializer);
                 jArgs.Add(new JProperty("record", jproprecord));
             }
             if (channel != null)
             {
                 var jpropchannel = JToken.FromObject(channel, _client.Serializer);
                 jArgs.Add(new JProperty("channel", jpropchannel));
             }
            return await _client.GetData<string>("PVR.Record", jArgs);
        }

                /// <summary>
                /// Toggle recording of a channel
                /// </summary>
        public async Task<string> Record(object channel=null)
        {
            var jArgs = new JObject();
             if (channel != null)
             {
                 var jpropchannel = JToken.FromObject(channel, _client.Serializer);
                 jArgs.Add(new JProperty("channel", jpropchannel));
             }
            return await _client.GetData<string>("PVR.Record", jArgs);
        }

                /// <summary>
                /// Starts a channel scan
                /// </summary>
        public async Task<string> Scan()
        {
            var jArgs = new JObject();
            return await _client.GetData<string>("PVR.Scan", jArgs);
        }
   }
}
