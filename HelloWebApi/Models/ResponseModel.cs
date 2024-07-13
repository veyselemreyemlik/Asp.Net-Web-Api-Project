using System.Net;

namespace HelloWebApi.Models
{
    public class ResponseModel
    {
        public int HttpStatusCode  { get; set; }
        public string StatusMessage { get; set; }
    }
}
