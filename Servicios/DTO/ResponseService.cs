using System;
using System.Collections.Generic;
using System.Net;

namespace Servicios.DTO
{
    public class ResponseService
    {
        public List<string> Messages { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool Success { get; set; }
    }
}
