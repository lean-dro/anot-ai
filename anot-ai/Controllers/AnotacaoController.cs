using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Models;
using anot_ai.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace anot_ai.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnotacaoController : ControllerBase
    {
        private IAnotacaoRepository _anotacaoRepository;

        public AnotacaoController(IAnotacaoRepository anotacaoRepository)
        {
            _anotacaoRepository = anotacaoRepository;
        }

        [HttpGet]
        public ActionResult<List<AnotacaoDTO>> Listar()
        {
            return Ok(AnotacaoMapper.ParaDTO(_anotacaoRepository.ListarAnotacoes()));
        }

        [HttpGet("{id}")]
        public ActionResult<AnotacaoDTO> Buscar(int id)
        {
            var busca = _anotacaoRepository.BuscarAnotacaoPorId(id);
            if (busca == null) return NotFound();
            return Ok(AnotacaoMapper.ParaDTO(busca));
        }


        [HttpPost]
        public IActionResult Criar(NovaAnotacao nova)
        {
            _anotacaoRepository.CriarNovaAnotacao(nova);
            return Created();
        }
        [HttpPost("Lote")]
        public IActionResult CriarLote(List<NovaAnotacao> novas)
        {
            for (int i = 0; i < novas.Count; i++)
            {
                _anotacaoRepository.CriarNovaAnotacao(novas[i]);
            }
            
            return Created();
        }



        [HttpPut("{id}")]
        public ActionResult AtualizarSmart(int id, [FromBody] AtualizacaoAnotacaoSimples atualizacaoAnotacaoSimples)
        {
            if (_anotacaoRepository.BuscarAnotacaoPorId(id) == null) return NotFound();
            _anotacaoRepository.AtualizarAnotacao(id, atualizacaoAnotacaoSimples);
            return NoContent();
        }


        [HttpPut("IA/{id}")]
        public ActionResult AtualizarSmartComIA(int id, [FromBody] AtualizacaoAnotacaoSimples atualizacaoAnotacaoSimples)
        {
            if (_anotacaoRepository.BuscarAnotacaoPorId(id) == null) return NotFound();
            _anotacaoRepository.AtualizarAnotacaoComIA(id, atualizacaoAnotacaoSimples);
            return NoContent();
        }




        [HttpDelete("{id}")]
        public ActionResult DeletarTodas(int id)
        {

            var busca = _anotacaoRepository.BuscarAnotacaoPorId(id);
            if (busca == null)
            {
                return NotFound();
            }
            _anotacaoRepository.DeletarAnotacao(busca);
            return NoContent();
        }


    }
}
