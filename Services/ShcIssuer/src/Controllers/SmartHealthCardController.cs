using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ShcIssuer.Models;
using ShcIssuer.Models.Multipart;
using ShcIssuer.Services;

namespace ShcIssuer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmartHealthCardController : ControllerBase
    {
        private readonly ILogger<SmartHealthCardController> logger;
        private readonly ISmartHealthCardService service;


        public SmartHealthCardController(ILogger<SmartHealthCardController> logger,
            ISmartHealthCardService service)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpPost]
        [Route("/Patient/{id}/$smart-health-card-bundle")]
        public IActionResult CreateSmartHealthCardBundle([FromBody] HealthCardIssueRequest request, string id)
        {

            return new MultipartResult()
            {
                new MultipartEntry()
                {
                    ContentType = "application/smart-health-card",
                    FileName = "SmartHealthCard.smart-health-card",
                    Stream = null,
                },
                new MultipartEntry()
                {
                    ContentType = "image/png",
                    FileName = "smart-health-card.png",
                    Stream = null,
                }
            };
        }

        [HttpPost]
        [Route("/Patient/{id}/$health-cards-issue")]
        [Produces("application/smart-health-card")]
        public async Task<ActionResult<SmartHealthCardModel>> CreateSmartHealthCard([FromBody] HealthCardIssueRequest request, string id)
        {
            return new SmartHealthCardModel();
        }
    }
}
