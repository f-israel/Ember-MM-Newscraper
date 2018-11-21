using System;
using System.Linq;
using Newtonsoft.Json;
using XBMCRPC.List.Filter;

namespace XBMCRPC.List.Filter
{
    [JsonConverter(typeof(OperatorEnumConverter))]
    public enum Operators
   {
       contains,
       doesnotcontain,
       Is,
       isnot,
       startswith,
       endswith,
       greaterthan,
       lessthan,
       after,
       before,
       inthelast,
       notinthelast,
       True,
       False,
       between
   }
}

public class OperatorEnumConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        Operators op = (Operators)value;
        writer.WriteValue(op.ToString().ToLower());
    }
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        var values = Enum.GetNames(typeof(Operators));
        var enumValue = values.FirstOrDefault(v => v.ToLower().Equals(reader.Value.ToString()));
        Operators op;
        if (Enum.TryParse(enumValue, out op))
        {
            return op;
        }
        return null;
    }
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(string);
    }
}
