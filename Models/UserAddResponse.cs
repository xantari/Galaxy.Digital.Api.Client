using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserAddResponse : ApiResponseBase
    {
        public UserAddResponse()
        {
        }

        public UserAddUserResponse Data { get; set; }
    }
}
