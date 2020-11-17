using Galaxy.Digital.Api.Client.Converters;
using Galaxy.Digital.Api.Client.Models;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Serialization
{
    class GalaxyDigitalContractResolver : DefaultContractResolver
    {
        public GalaxyDigitalContractResolver()
        {
            this.NamingStrategy = new CamelCaseNamingStrategy();
        }
        protected override JsonObjectContract CreateObjectContract(Type objectType)
        {
            JsonObjectContract contract = base.CreateObjectContract(objectType);
            if (objectType == typeof(KeyValueModel))
            {
                contract.Converter = new KeyValueModelConverter();
            }
            return contract;
        }
    }
}
