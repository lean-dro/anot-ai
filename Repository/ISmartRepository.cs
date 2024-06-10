using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Repository
{
    public interface ISmartRepository
    {
        bool CriarNovoSmart(Smart smart);
        Smart? BuscarSmartPorID(int id);
        List<Smart> ListarSmarts();
        void AtualizarSmart(int id, SmartDTO atualizacaoSmart);

    }
}
