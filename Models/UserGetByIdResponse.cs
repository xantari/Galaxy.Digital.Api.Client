using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserGetByIdResponse : ApiResponseBase
    {
        public UserGetByIdResponse()
        {
        }

        public UserGetByIdUserResponse Data { get; set; }
    }
}
