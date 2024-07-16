using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Repository
{
    public interface IMonitoramentoRepository
    {

        void Criar(Anotacao anotacao, MonitoramentoSimples monitoramento);
        void Atualizar(int id, string monitoramento);
        void Excluir(Monitoramento id);

        Monitoramento? BuscarMonitoramentoPeloId(int id);
    }
}
