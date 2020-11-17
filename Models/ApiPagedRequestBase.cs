using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class ApiPagedRequestBase : ApiRequestBase
    {
        public ApiPagedRequestBase() { }
        public int? Offset { get; set; }
        public int? Limit { get; set; }
    }
}
