using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using XBMCRPC.Video;

namespace XBMCRPC.List.Item
{
    [JsonConverter(typeof(ListItemBaseConverter))]
   public class Base
   {
       public string album { get; set; }
       public List<string> albumartist { get; set; }
       public List<int> albumartistid { get; set; }
       public int albumid { get; set; }
       public string albumlabel { get; set; }
       public List<CastItem> cast { get; set; }
       public string comment { get; set; }
       public List<string> country { get; set; }
       public string description { get; set; }
       public int disc { get; set; }
       public int duration { get; set; }
       public int episode { get; set; }
       public string episodeguide { get; set; }
       public string firstaired { get; set; }
       public int id { get; set; }
       public string imdbnumber { get; set; }
       public string lyrics { get; set; }
       public List<string> mood { get; set; }
       public string mpaa { get; set; }
       public string musicbrainzartistid { get; set; }
       public string musicbrainztrackid { get; set; }
       public string originaltitle { get; set; }
       public string plotoutline { get; set; }
       public string premiered { get; set; }
       public string productioncode { get; set; }
       public int season { get; set; }
       public string set { get; set; }
       public int setid { get; set; }
       public List<string> showlink { get; set; }
       public string showtitle { get; set; }
       public string sorttitle { get; set; }
       public List<string> studio { get; set; }
       public List<string> style { get; set; }
       public List<string> tag { get; set; }
       public string tagline { get; set; }
       public List<string> theme { get; set; }
       public int top250 { get; set; }
       public int track { get; set; }
       public string trailer { get; set; }
       public int tvshowid { get; set; }
       public Base_type type { get; set; }
       public Base_uniqueid uniqueid { get; set; }
       public string votes { get; set; }
       public int watchedepisodes { get; set; }
       public List<string> writer { get; set; }
       [JsonIgnore]
       public Video.Details.File AsVideoDetailsFile  { get; set; }
       [JsonIgnore]
       public Audio.Details.Media AsAudioDetailsMedia  { get; set; }
       [JsonIgnore]
       public Media.Details.Base AsMediaDetailsBase  { get; set; }
    }
    internal class ListItemBaseConverter : CustomCreationConverter<Base>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            var jObject = (JObject)serializer.Deserialize(reader);
            var localReader = new JTokenReader(jObject);
            var val = (Base)base.ReadJson(localReader, objectType, existingValue, serializer);

            localReader = new JTokenReader(jObject);
            val.AsVideoDetailsFile = serializer.Deserialize<Video.Details.File>(localReader);
            localReader = new JTokenReader(jObject);
            val.AsAudioDetailsMedia = serializer.Deserialize<Audio.Details.Media>(localReader);
            localReader = new JTokenReader(jObject);
            val.AsMediaDetailsBase = serializer.Deserialize<Media.Details.Base>(localReader);

            return val;
        }

		  public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Base);
        }

        public override Base Create(Type objectType)
        {
            return (Base) Activator.CreateInstance(objectType);
        }
    }
}
