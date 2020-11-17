using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserUpdateResponse : ApiResponseBase
    {
        public UserUpdateResponse()
        {
        }

        public UserUpdateUserResponse Data { get; set; }
    }
}
