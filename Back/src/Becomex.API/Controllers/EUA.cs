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
    public class EUAController : ControllerBase
    {
        public EUAController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "População EUA: 329,5 milhões; Timezone: UTC -7 - Mountain Standard Time (MST) UTC -6 - Central Standard Time (CST) UTC -5 - Eastern Standard Time (EST) UTC -4 - Atlantic Standard Time (AST); Moeda: Dólar; Lingua: Inglês; Capital: Washignton D.C.; Blocos econômicos: NAFTA e APEC";
        }
    }
}
