using Galaxy.Digital.Api.Client.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserGetByIdUserResponse : UserResponse
    {
        public UserGetByIdUserResponse()
        {
        }

        /// <summary>
        /// Link to be used that will auto-log user into the site. Note: must pass "getLogin" parameter in request to receive.
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// The time, in ISO 8601 format, that this link will expire.
        /// </summary>
        public DateTime? Expires { get; set; }
        /// <summary>
        /// The current server time in ISO 8601 format.
        /// </summary>
        public DateTime? Now { get; set; }
    }
}
