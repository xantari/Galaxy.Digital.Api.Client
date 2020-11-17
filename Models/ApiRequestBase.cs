using Galaxy.Digital.Api.Client.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class ApiRequestBase
    {
        public ApiRequestBase() { }
        /// <summary>
        /// Api Key
        /// </summary>
        public string Key { get; } = GalaxyDigitalApiClientConfig.ApiKey;
    }
}
