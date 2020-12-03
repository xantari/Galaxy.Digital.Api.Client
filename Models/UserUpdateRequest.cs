using Galaxy.Digital.Api.Client.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserUpdateRequest : ApiRequestBase
    {
        public UserUpdateRequest() 
        {
        }

        public UserUpdateRequest(string firstName, string lastName, string email, string password) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        [JsonProperty(Required = Required.Always)]
        public int Id { get; set; }
        public string ReferenceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        /// <summary>
        /// Current Status (Active, Inactive)
        /// </summary>
        public string Status { get; set; }
        public string Mobile { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Gender { get; set; }
        public string GradSemester { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public string DisasterContact { get; set; }
        public DateTime? DateUserAccountExpires { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }

        public Dictionary<string,string> ExtraAdd { get; set; }
        public Dictionary<string, string> ExtraRemove { get; set; }
        public Dictionary<string, string> ExtraUpdate { get; set; }
        public List<string> TagsAdd { get; set; }
        public List<string> TagsRemove { get; set; }
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
