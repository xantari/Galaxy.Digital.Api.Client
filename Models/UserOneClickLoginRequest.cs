using Galaxy.Digital.Api.Client.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserOneClickLoginRequest : ApiRequestBase
    {
        public UserOneClickLoginRequest() 
        {
        }


        public int Id { get; set; }
        /// <summary>
        /// Request additional user data as part of the result set. You may use "registration", "extras", "tags", "interests","stats", "qualifications", 
        /// and/or "favoriteAgencies". e.g. return[]='extras' return[]='tags'
        /// </summary>
        public List<string> Return { get; set; }
    }
}
