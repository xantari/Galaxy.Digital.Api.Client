using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserStatistics
    {
        public decimal HoursAllTime { get; set; }
        public decimal ImpactValue { get; set; }
        public decimal AgenciesFanned { get; set; }
        public decimal NeedResponses { get; set; }
        public decimal EventRsvp { get; set; } 
    }
}
