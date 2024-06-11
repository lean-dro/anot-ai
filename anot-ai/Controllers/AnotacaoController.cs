using anot_ai.Data.DTO;
using anot_ai.Models;
using anot_ai.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public IActionResult Criar(NovaAnotacao nova)
        {
            _anotacaoRepository.CriarNovaAnotacao(nova);
            return Created();
        }
        [HttpGet]
        public ActionResult<List<Anotacao>> Listar()
        {
            return Ok(_anotacaoRepository.ListarAnotacoes());
        }
        [HttpPut("/{id}")]
        public ActionResult Atualizar(int id, [FromBody] AtualizacaoAnotacao atualizacao)
        {
            if (_anotacaoRepository.BuscarAnotacaoPorId(id) == null) return NotFound();
            _anotacaoRepository.AtualizarAnotacao(id, atualizacao);
            return NoContent();
        }

        [HttpDelete]
        public ActionResult<List<Anotacao>> DeletarTodas()
        {
            _anotacaoRepository.Limpar();
            return Ok();
        }


    }
}
