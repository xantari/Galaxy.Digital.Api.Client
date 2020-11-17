using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "imported")]
        Imported
    }

    //"id", "email", or "referenceId". 
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdType
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "referenceId")]
        ReferenceId
    }
}
