using Microsoft.AspNetCore.Mvc;
using HelloWebApi.Models;
namespace HelloWebApi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage() {
            var result =  new ResponseModel()
            {
                HttpStatusCode = 200,
                StatusMessage = "Hello Asp.Net Core Web Api"
            };
            return Ok(result);
        }
    }
}
