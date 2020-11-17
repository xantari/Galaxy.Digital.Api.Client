using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class ApiPagedResponseBase : ApiResponseBase
    {
        public ApiPagedResponseBase() { }
        public int Rows { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}
