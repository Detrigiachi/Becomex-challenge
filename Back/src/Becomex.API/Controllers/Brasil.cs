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
    public class BrasilController : ControllerBase
    {
        public BrasilController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "População Russia: 212,6 milhões; Timezone: o Horário de Fernando de Noronha (FNT – Fernando de Noronha Time em UTC-02:00); o Horário de Brasília (BRT – Brasília Time em UTC-03:00); o Horário da Amazônia (AMT – Amazon Time em UTC-04:00); o Horário do Acre (ACT – Acre Time em UTC-05:00); Moeda: Real; Lingua: Português; Capital: Brasília; Blocos econômicos: Mercosul, Mercosul-Israel, Mercosul-Egito, Mercosul-UE, ALADI";
        }
    }
}
