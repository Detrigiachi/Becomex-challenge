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
    public class EspanhaController : ControllerBase
    {
        public EspanhaController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "População Espanha: 47,35 milhões; Timezone: Madrid, Espanha (GMT+2); Moeda: Euro; Lingua: Espanhol; Capital: Madrid; Blocos econômicos: OMC, União Europeia, OCDE";
        }
    }
}
