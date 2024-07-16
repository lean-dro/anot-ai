using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Repository;
using anot_ai.Services;
using Microsoft.AspNetCore.Mvc;

namespace anot_ai.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmartController : ControllerBase
    {
        private ISmartRepository _smartRepository;
        private IAnotacaoRepository _anotacaoRepository;

        public SmartController(ISmartRepository smartRepository, IAnotacaoRepository anotacaoRepository = null)
        {

            _smartRepository = smartRepository;
            _anotacaoRepository = anotacaoRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<SmartDTO> Buscar(int id)
        {
            var busca = _smartRepository.BuscarSmartPeloId(id);
            if (busca == null)
            {
                return NotFound("SMART não encontrado");
            }
            return SmartMapper.ParaDTO(busca);
        }
        [HttpPost("Anotacao/{id}")]
        public IActionResult Criar(int id, [FromBody] SmartSimples smart)
        {
            var anotacao = _anotacaoRepository.BuscarAnotacaoPeloId(id);
            if (anotacao == null)
            {
                return NotFound("Anotação não encontrada");
            }
            _smartRepository.Criar(anotacao, smart);
            return Created();
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            var busca = _smartRepository.BuscarSmartPeloId(id);
            if (busca == null)
            {
                return NotFound("SMART não encontrado");
            }
            _smartRepository.Excluir(busca);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody]SmartSimples smart)
        {
            var busca = _smartRepository.BuscarSmartPeloId(id);
            if (busca == null)
            {
                return NotFound("SMART não encontrado");
            }
            _smartRepository.Atualizar(id, smart);
            return NoContent();
        }
    }
}
