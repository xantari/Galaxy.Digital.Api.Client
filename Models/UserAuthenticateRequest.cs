using Galaxy.Digital.Api.Client.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserAuthenticateRequest : ApiRequestBase
    {
        public UserAuthenticateRequest() 
        {
        }


        public string Email { get; set; }
        public string Password { get; set; }
        public bool? GetLogin { get; set; }
        /// <summary>
        /// Request additional user data as part of the result set. You may use "registration", "extras", "tags", "interests","stats", "qualifications", 
        /// and/or "favoriteAgencies". e.g. return[]='extras' return[]='tags'
        /// </summary>
        public List<string> Return { get; set; }
    }
}
