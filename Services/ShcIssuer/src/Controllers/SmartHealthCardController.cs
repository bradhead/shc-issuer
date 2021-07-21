using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ShcIssuer.Models;

namespace ShcIssuer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmartHealthCardController : ControllerBase
    {

        private readonly ILogger<SmartHealthCardController> _logger;

        public SmartHealthCardController(ILogger<SmartHealthCardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public SmartHealthCardBundle Get()
        {
            return new SmartHealthCardBundle();
        }
    }
}
