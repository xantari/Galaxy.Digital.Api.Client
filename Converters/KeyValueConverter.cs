using Galaxy.Digital.Api.Client.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Converters
{
    public class KeyValueModelConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);

            foreach (var prop in jObject)
            {
                return new KeyValueModel { Key = prop.Key, Value = prop.Value.ToString() };
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(KeyValueModel).IsAssignableFrom(objectType);
        }
    }
}
