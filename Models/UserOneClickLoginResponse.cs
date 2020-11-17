using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserOneClickLoginResponse : ApiResponseBase
    {
        public UserOneClickLoginResponse()
        {
        }

        public UserOneClickResponse Data { get; set; }
    }
}
