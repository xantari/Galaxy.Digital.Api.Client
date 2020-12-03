using Galaxy.Digital.Api.Client.Models;
using Galaxy.Digital.Api.Client.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy.Digital.Api.Client
{
    public interface IUserClient
    {
        UserListResponse GetUserList(UserListRequest request);
        Task<UserListResponse> GetUserListAsync(UserListRequest request);
        Task<UserListResponse> GetUserListAsync(UserListRequest request, CancellationToken cancellationToken);

        UserGetByIdResponse GetById(UserGetByIdRequest request);
        Task<UserGetByIdResponse> GetByIdAsync(UserGetByIdRequest request);
        Task<UserGetByIdResponse> GetByIdAsync(UserGetByIdRequest request, CancellationToken cancellationToken);

        UserAddResponse AddUser(UserAddRequest request);
        Task<UserAddResponse> AddUserAsync(UserAddRequest request);
        Task<UserAddResponse> AddUserAsync(UserAddRequest request, CancellationToken cancellationToken);

        UserUpdateResponse UpdateUser(UserUpdateRequest request);
        Task<UserUpdateResponse> UpdateUserAsync(UserUpdateRequest request);
        Task<UserUpdateResponse> UpdateUserAsync(UserUpdateRequest request, CancellationToken cancellationToken);

        UserOneClickLoginResponse GetUserOneClickLogin(UserOneClickLoginRequest request);
        Task<UserOneClickLoginResponse> GetUserOneClickLoginAsync(UserOneClickLoginRequest request);
        Task<UserOneClickLoginResponse> GetUserOneClickLoginAsync(UserOneClickLoginRequest request, CancellationToken cancellationToken);

        UserAuthenticateResponse UserAuthenticate(UserAuthenticateRequest request);
        Task<UserAuthenticateResponse> UserAuthenticateAsync(UserAuthenticateRequest request);
        Task<UserAuthenticateResponse> UserAuthenticateAsync(UserAuthenticateRequest request, CancellationToken cancellationToken);
    }
    public partial class UserClient : ClientBase, IUserClient
    {
        private readonly HttpClient _httpClient;
        private readonly Lazy<JsonSerializerSettings> _settings;

        public UserClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _settings = new Lazy<JsonSerializerSettings>(CreateSerializerSettings);
            //11/17/2020 - MRO: Currently can't read by streams because we have to patch their JSON data due to bugs in their array versus null response types.
            //12/03/2020 - MRO: They fixed their bug with their JSON result types, switching back to more efficient streams instead of string mode
            ReadResponseAsString = false;
        }


        private JsonSerializerSettings CreateSerializerSettings()
        {
            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new GalaxyDigitalContractResolver(); 
            settings.NullValueHandling = NullValueHandling.Ignore;
            return settings;
        }

        protected JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

        public UserListResponse GetUserList(UserListRequest request)
        {
            return Task.Run(async () => await GetUserListAsync(request, CancellationToken.None)).GetAwaiter().GetResult();
        }

        public Task<UserListResponse> GetUserListAsync(UserListRequest request)
        {
            return GetUserListAsync(request, CancellationToken.None);
        }

        public async Task<UserListResponse> GetUserListAsync(UserListRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/volunteer/user/list");

            using (var request_ = await CreateHttpRequestMessageAsync(cancellationToken).ConfigureAwait(false))
            {
                var content = new StringContent(JsonConvert.SerializeObject(request, _settings.Value));
                content.Headers.ContentType =MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                //PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                //PrepareRequest(client_, request_, url_);

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    //ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<UserListResponse>(response_, headers_).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (response_ != null)
                        response_.Dispose();
                }
            }
        }

        public UserGetByIdResponse GetById(UserGetByIdRequest request)
        {
            return Task.Run(async () => await GetByIdAsync(request, CancellationToken.None)).GetAwaiter().GetResult();
        }

        public Task<UserGetByIdResponse> GetByIdAsync(UserGetByIdRequest request)
        {
            return GetByIdAsync(request, CancellationToken.None);
        }

        public async Task<UserGetByIdResponse> GetByIdAsync(UserGetByIdRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/volunteer/user/get");

            using (var request_ = await CreateHttpRequestMessageAsync(cancellationToken).ConfigureAwait(false))
            {
                var content = new StringContent(JsonConvert.SerializeObject(request, _settings.Value));
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                //PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                //PrepareRequest(client_, request_, url_);

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    //ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<UserGetByIdResponse>(response_, headers_).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (response_ != null)
                        response_.Dispose();
                }
            }
        }

        public UserAddResponse AddUser(UserAddRequest request)
        {
            return Task.Run(async () => await AddUserAsync(request, CancellationToken.None)).GetAwaiter().GetResult();
        }

        public Task<UserAddResponse> AddUserAsync(UserAddRequest request)
        {
            return AddUserAsync(request, CancellationToken.None);
        }

        public async Task<UserAddResponse> AddUserAsync(UserAddRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/volunteer/user/add");

            using (var request_ = await CreateHttpRequestMessageAsync(cancellationToken).ConfigureAwait(false))
            {
                var content = new StringContent(JsonConvert.SerializeObject(request, _settings.Value));
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                //PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                //PrepareRequest(client_, request_, url_);

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    //ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<UserAddResponse>(response_, headers_).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (response_ != null)
                        response_.Dispose();
                }
            }
        }

        public UserUpdateResponse UpdateUser(UserUpdateRequest request)
        {
            return Task.Run(async () => await UpdateUserAsync(request, CancellationToken.None)).GetAwaiter().GetResult();
        }

        public Task<UserUpdateResponse> UpdateUserAsync(UserUpdateRequest request)
        {
            return UpdateUserAsync(request, CancellationToken.None);
        }

        public async Task<UserUpdateResponse> UpdateUserAsync(UserUpdateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/volunteer/user/update");

            using (var request_ = await CreateHttpRequestMessageAsync(cancellationToken).ConfigureAwait(false))
            {
                var content = new StringContent(JsonConvert.SerializeObject(request, _settings.Value));
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                //PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                //PrepareRequest(client_, request_, url_);

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    //ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<UserUpdateResponse>(response_, headers_).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (response_ != null)
                        response_.Dispose();
                }
            }
        }

        public UserOneClickLoginResponse GetUserOneClickLogin(UserOneClickLoginRequest request)
        {
            return Task.Run(async () => await GetUserOneClickLoginAsync(request, CancellationToken.None)).GetAwaiter().GetResult();
        }

        public Task<UserOneClickLoginResponse> GetUserOneClickLoginAsync(UserOneClickLoginRequest request)
        {
            return GetUserOneClickLoginAsync(request, CancellationToken.None);
        }

        public async Task<UserOneClickLoginResponse> GetUserOneClickLoginAsync(UserOneClickLoginRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/volunteer/user/oneclick");

            using (var request_ = await CreateHttpRequestMessageAsync(cancellationToken).ConfigureAwait(false))
            {
                var content = new StringContent(JsonConvert.SerializeObject(request, _settings.Value));
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                //PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                //PrepareRequest(client_, request_, url_);

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    //ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<UserOneClickLoginResponse>(response_, headers_).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (response_ != null)
                        response_.Dispose();
                }
            }
        }

        public UserAuthenticateResponse UserAuthenticate(UserAuthenticateRequest request)
        {
            return Task.Run(async () => await UserAuthenticateAsync(request, CancellationToken.None)).GetAwaiter().GetResult();
        }

        public Task<UserAuthenticateResponse> UserAuthenticateAsync(UserAuthenticateRequest request)
        {
            return UserAuthenticateAsync(request, CancellationToken.None);
        }

        public async Task<UserAuthenticateResponse> UserAuthenticateAsync(UserAuthenticateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/volunteer/user/authenticate");

            using (var request_ = await CreateHttpRequestMessageAsync(cancellationToken).ConfigureAwait(false))
            {
                var content = new StringContent(JsonConvert.SerializeObject(request, _settings.Value));
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                //PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                //PrepareRequest(client_, request_, url_);

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    //ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<UserAuthenticateResponse>(response_, headers_).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                        }
                        return objectResponse_.Object;
                    }
                    else
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (response_ != null)
                        response_.Dispose();
                }
            }
        }

        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                this.Object = responseObject;
                this.Text = responseText;
            }

            public T Object { get; }

            public string Text { get; }
        }

        public bool ReadResponseAsString { get; set; }

        protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default(T), string.Empty);
            }

            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                //Case # 66391: Fix bug in galaxy digital where they incorrectly change the response type of objects from Dictionary<string,string> to array based JSON 
                //If they ever fix this, remove the below line. This happens in the userList API, when you encounter someone who doesn't have any "extras" defined. They denote it as
                //extras: [], when it should be extras: null, because what they normally return there is NOT a JSON array. So they are switching the context of that field improperly.
                //12/3/2020: They fixed this bug, switching back to streaming mode which should be more efficient
                responseText = responseText.Replace("[]", "null"); 
                try
                {
                    var typedBody = JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new StreamReader(responseStream))
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                        var serializer = JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }

        //private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        //{
        //    if (value == null)
        //    {
        //        return null;
        //    }

        //    if (value is System.Enum)
        //    {
        //        var name = System.Enum.GetName(value.GetType(), value);
        //        if (name != null)
        //        {
        //            var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
        //            if (field != null)
        //            {
        //                var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
        //                    as System.Runtime.Serialization.EnumMemberAttribute;
        //                if (attribute != null)
        //                {
        //                    return attribute.Value != null ? attribute.Value : name;
        //                }
        //            }

        //            return System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
        //        }
        //    }
        //    else if (value is bool)
        //    {
        //        return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
        //    }
        //    else if (value is byte[])
        //    {
        //        return System.Convert.ToBase64String((byte[])value);
        //    }
        //    else if (value.GetType().IsArray)
        //    {
        //        var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
        //        return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
        //    }

        //    var result = System.Convert.ToString(value, cultureInfo);
        //    return (result is null) ? string.Empty : result;
        //}
    }
}
