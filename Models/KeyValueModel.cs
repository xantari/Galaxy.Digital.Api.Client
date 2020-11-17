using Galaxy.Digital.Api.Client.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    [JsonConverter(typeof(KeyValueModelConverter))]
    public class KeyValueModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
