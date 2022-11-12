using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleErrorService : ControllerBase
    {
        [HttpGet]
        public void ExampleErrors()
        {
            throw new IndexOutOfRangeException("IndexOutOfRangeException");
        }
    }
}
