﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWorld.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public  class HelloController : ControllerBase
    {

        public string Get()
        {
            return "Hello World from Shelton!";
        }
    }
}
