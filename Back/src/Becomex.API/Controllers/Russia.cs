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
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "População Russia: 144,1 milhões de pessoas; Timezone: Moscovo, Moscou, Rússia (GMT+3); Moeda: Rublo russo; Lingua: Russo; Capital: Moscou; Blocos econômicos: OMC, CEI, G-20, BRICS e outros";
        }
    }
}

