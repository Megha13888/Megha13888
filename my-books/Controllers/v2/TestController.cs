using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get-test-data")]
        public IActionResult Get()
        {
            return Ok("This is TestController V2");
        }

        [HttpGet("getdata")]
        public IActionResult GetData()
        {
            return Ok("This is Update Data in v2");
        }

        [HttpGet("getdatadevelopment")]
        public IActionResult GetDevelopmentAPI()
        {
            return Ok("Development API");
        }

        [HttpGet("getTestData")]
        public IActionResult GetTestData()
        {
            return Ok("Development API");
        }


        [HttpGet("getTestDatav1")]
        public IActionResult GetTestDatav1()
        {
            return Ok("Development API v1");
        }
    }
}
