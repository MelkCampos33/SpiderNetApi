using Microsoft.AspNetCore.Mvc;
using SpiderMissionApi.Model;
using System.Collections.Generic;

namespace SpiderMissionApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissoesController  : ControllerBase
    {
        private static List<SpiderMission> mission = new List<SpiderMission>();

        // --- Rotas da API ---

        // GET
        [HttpGet]
        public ActionResult<IEnumerable<SpiderMission>> Get()
        {
            return Ok(mission);
        }

        // POST
        [HttpPost]
        public ActionResult Post([FromBody] SpiderMission novaMissao)
        {
            // Validação do nível de perigo.
            if(novaMissao.NivelPerigo < 1 || novaMissao.NivelPerigo > 10)
            {
                return BadRequest(" O Nivel de perigo deve estar entre 1 e 10 ");
            }

            mission.Add(novaMissao);
            return Created("", novaMissao);

        }



    }
}  