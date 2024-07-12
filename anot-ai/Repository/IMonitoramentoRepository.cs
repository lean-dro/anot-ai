using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Repository
{
    public interface IMonitoramentoRepository
    {

        public void Criar(Anotacao anotacao, MonitoramentoSimples monitoramento);
        public void Atualizar(int id, string monitoramento);
        public void Excluir(Monitoramento id);

        public Monitoramento? BuscarMonitoramentoPeloId(int id);
    }
}
