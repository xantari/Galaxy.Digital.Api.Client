using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Config
{
    public class GalaxyDigitalApiClientConfig
    {
        public static string ApiEndpoint { get; } = "https://api2.galaxydigital.com";
        public static string ApiKey { get; set; } = string.Empty;
    }
}
