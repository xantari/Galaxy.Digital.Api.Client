using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserListRequest : ApiPagedRequestBase
    {
        public UserListRequest()
        {
            //Where = new List<string>();
        }

        /// <summary>
        /// This will filter results where a specific item is equal to the value passed. e.g. where[firstName]=Jim
        /// </summary>
        public Dictionary<string,string> Where { get; set; }
        /// <summary>
        /// This will filter results where a specific item is contains the value passed. e.g. like[lastName]=oe, which will pick up names like "Doe" and "Hoehn"
        /// </summary>
        public Dictionary<string, string> Like { get; set; }
        /// <summary>
        /// This will filter results based on the user's current status. You may use 'active', 'inactive', 'pending', or 'imported'
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// This will return users with a user id that is greater than the id specified.
        /// </summary>
        public int? SinceId { get; set; }
        /// <summary>
        /// This will return users that have been added to the system since the date specified. Format: yyyy-mm-dd
        /// </summary>
        public DateTime? SinceDate { get; set; }
        /// <summary>
        /// Request additional user data as part of the result set. You may use "registration", "extras", "tags", "interests","stats", "qualifications", 
        /// and/or "favoriteAgencies". e.g. return[]='extras' return[]='tags'
        /// </summary>
        public List<string> Return { get; set; }
    }
}
