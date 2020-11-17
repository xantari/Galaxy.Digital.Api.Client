using Galaxy.Digital.Api.Client.Config;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy.Digital.Api.Client
{
    /// <summary>
    /// All successful requests will return a 200 status code, but it is possible to get a 400 if you have a bad api key, 
    /// or a 502 if you are timed out or if we happen to be pushing an update to the API. 
    /// </summary>
    public abstract class ClientBase
    {
        public ClientBase()
        {
            if (string.IsNullOrEmpty(GalaxyDigitalApiClientConfig.ApiKey))
                throw new Exception("Galaxy Digital Api Key Not defined. Did you forget to set GalaxyDigitalApiClientConfig.ApiKey?");
        }

        public string BaseUrl
        {
            get { return GalaxyDigitalApiClientConfig.ApiEndpoint; }
        }

        protected async Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken) => await Task.FromResult(new HttpRequestMessage());
    }
}
