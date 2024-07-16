using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Repository
{
    public interface ISmartRepository
    {
        void Criar(Anotacao anotacao,SmartSimples smart);
        Smart? BuscarSmartPeloId(int id);
        void Atualizar(int id, SmartSimples atualizacao);
        void Excluir(Smart smart);
    }
}
