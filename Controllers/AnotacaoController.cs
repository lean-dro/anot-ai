using anot_ai.Data.DTO;
using anot_ai.Models;
using anot_ai.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace anot_ai.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnotacaoController : ControllerBase
    {
        private IAnotacaoRepository _anotacaoRepository;

        public AnotacaoController(IAnotacaoRepository anotacaoRepository)
        {
            _anotacaoRepository = anotacaoRepository;
        }

        [HttpPost]
        public IActionResult criarNovo(NovaAnotacao nova)
        {
            _anotacaoRepository.criarNovaAnotacao(nova);
            return Created();
        }
        [HttpGet]
        public ActionResult<List<Anotacao>> listar()
        {
            return Ok(_anotacaoRepository.listarAnotacoes());
        }

    }
}
