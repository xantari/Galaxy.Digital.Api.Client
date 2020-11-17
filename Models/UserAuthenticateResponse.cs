using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserAuthenticateResponse : ApiResponseBase
    {
        public UserAuthenticateResponse()
        {
        }

        public UserAuthenticateUserResponse Data { get; set; }
    }
}
