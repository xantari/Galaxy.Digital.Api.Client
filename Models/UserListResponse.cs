using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class UserListResponse : ApiPagedResponseBase
    {
        public UserListResponse()
        {
        }

        public List<UserResponse> Data { get; set; }
    }
}
