using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserGetByIdRequest : ApiRequestBase
    {
        public UserGetByIdRequest()
        {
        }

        public string Id { get; set; }
        /// <summary>
        /// Type of unique identifier you will be using to request the user record. You may use "id", "email", or "referenceId". 
        /// The default is "id", which is the GetConnected user ID.
        /// </summary>
        public string IdType { get; set; }
        /// <summary>
        /// Request to create and return one-click login for this user.
        /// </summary>
        public bool? GetLogin { get; set; }
        /// <summary>
        /// Request additional user data as part of the result set. You may use "registration", "extras", "tags", "interests","stats", "qualifications", 
        /// and/or "favoriteAgencies". e.g. return[]='extras' return[]='tags'
        /// </summary>
        public List<string> Return { get; set; }
    }
}
