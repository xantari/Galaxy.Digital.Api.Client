using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class QualificationResponse
    {
        public int QualificationId { get; set; }
        public string QualitifcationCategory { get; set; }
        public string QualificationTitle { get; set; }
        public string QualificationUserResponse { get; set; }
        public DateTime QualificationUserExpires { get; set; } 
        public DateTime QualificationDateAdded { get; set; }
        /// <summary>
        /// "pending","active","expired"
        /// </summary>
        public string QualificationUserStatus { get; set; }
    }
}
