using Galaxy.Digital.Api.Client.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserAddUserResponse : UserResponse
    {
        public UserAddUserResponse()
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
        /// <summary>
        /// Indicates if the user you are attempting to add is a duplicate.
        /// </summary>
        public bool Duplicate { get; set; }
    }
}
