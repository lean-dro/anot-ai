using anot_ai.Data;
using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace anot_ai.Repository
{
    public class MonitoramentoRepository : IMonitoramentoRepository
    {
        private AnotacaoContext _context { get; set; }

        public MonitoramentoRepository(AnotacaoContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, string textoMonitoramento)
        {
            Monitoramento monitoramento = BuscarMonitoramentoPeloId(id);
            monitoramento.Check = textoMonitoramento;
            _context.SaveChanges();
        }

        public Monitoramento? BuscarMonitoramentoPeloId(int id)
        {
            var busca = _context.Monitoramentos.ToList().Find(m => m.Id == id);
            return busca;
        }

        public void Criar(Anotacao anotacao, MonitoramentoSimples novo)
        {
            if (anotacao.Monitoramento != null) {
                _context.Remove(anotacao.Monitoramento);
            }
            Monitoramento monitoramento = MonitoramentoMapper.ParaEntidade(novo);
            monitoramento.AnotacaoId = anotacao.Id;
            monitoramento.Anotacao = anotacao;
            _context.Monitoramentos.Add(monitoramento);
            _context.SaveChanges();
        }

        public void Excluir(Monitoramento monitoramento)
        {
            _context.Remove(monitoramento);
            _context.SaveChanges();
        }
    }
}
