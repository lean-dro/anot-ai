using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Services
{
    public interface IAnotacaoRepository
    {
        void criarNovaAnotacao(NovaAnotacao anotacao);
        List<Anotacao> listarAnotacoes();

    }
}