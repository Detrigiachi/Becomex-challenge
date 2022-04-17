using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SocialMedia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortugalController : ControllerBase
    {
        public PortugalController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "População Portugal: 10,31 milhões; Timezone: Lisboa, Portugal (GMT+1); Moeda: Euro; Lingua: Português; Capital: Lisboa; Blocos econômicos: OMC, União Europeia e OCDE";
        }
    }
}
