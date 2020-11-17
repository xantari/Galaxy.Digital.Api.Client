using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Digital.Api.Client.Models
{
    public class ApiResponseBase
    {
        public ApiResponseBase() { }
        /// <summary>
        /// "ok" - the request successfully returned some records​​
        /// "error": "No results for your request" for requests that require an id, this means an invalid ID was passed
        /// "message": "Unique identifier required"  for requests that require an id, this means the ID parameter was not included.
        /// </summary>
        public string Message { get; set; }

        public bool IsSuccessfulReponse()
        {
            return Message.ToLower() == "ok";
        }
    }
}
