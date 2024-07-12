using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Models;
using anot_ai.Repository;
using anot_ai.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace anot_ai.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonitoramentoController : ControllerBase
    {
        private IMonitoramentoRepository _monitoramentoRepository;
        private IAnotacaoRepository _anotacaoRepository;
        public MonitoramentoController(IMonitoramentoRepository monitoramentoRepository, IAnotacaoRepository anotacaoRepository)
        {
            _monitoramentoRepository = monitoramentoRepository;
            _anotacaoRepository = anotacaoRepository;
        }
        [HttpGet("{id}")]
        public ActionResult<MonitoramentoDTO> Buscar(int id)
        {
            var busca = _monitoramentoRepository.BuscarMonitoramentoPeloId(id);
            if (busca == null)
            {
                return NotFound("Monitoramento não encontrado");
            }
            return MonitoramentoMapper.ParaDTO(busca);
        }

        [HttpPost("Anotacao/{id}")]
        public IActionResult Criar(int id, [FromBody] MonitoramentoSimples novo)
        {
            var anotacao = _anotacaoRepository.BuscarAnotacaoPorId(id);
            if (anotacao == null)
            {
                return NotFound("Anotação não encontrada");
            }
            _monitoramentoRepository.Criar(anotacao, novo);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] MonitoramentoSimples novo)
        {
            var busca = _monitoramentoRepository.BuscarMonitoramentoPeloId(id);
            if (busca == null)
            {
                return NotFound("Monitoramento não encontrado");
            }
            _monitoramentoRepository.Atualizar(id, novo.Check);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<MonitoramentoDTO> Deletar(int id)
        {
            var busca = _monitoramentoRepository.BuscarMonitoramentoPeloId(id);
            if (busca == null)
            {
                return NotFound("Monitoramento não encontrado");
            }
            _monitoramentoRepository.Excluir(busca);
            return NoContent();
        }
    }
}
