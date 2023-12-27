using System;
using Microsoft.AspNetCore.Mvc;

namespace sampleApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ContentResult Get()
        {
            return Content($"<h1>Hello World!</h1><p>Timestamp: {DateTime.Now}</p>", "text/html");
        }
    }
}