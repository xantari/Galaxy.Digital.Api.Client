using Galaxy.Digital.Api.Client.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserResponse
    {
        public UserResponse()
        {
            Interests = new List<string>();
            Qualifications = new List<QualificationResponse>();
        }

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
        public DateTime? BirthDate { get; set; }
        public string DisasterContact { get; set; }
        public DateTime? DateUserAccountExpires { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateLastLogin { get; set; }

        public Dictionary<string,string> Extras { get; set; }
        //public List<Dictionary<string,string>> Extras { get; set; }
        public List<string> Interests { get; set; }
        public List<string> Tags { get; set; }
        public UserStatistics Stats { get; set; }
        public List<QualificationResponse> Qualifications { get; set; }
    }
}
