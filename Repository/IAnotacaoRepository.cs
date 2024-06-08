using anot_ai.Data.DTO;
using anot_ai.Models;
using Microsoft.CodeAnalysis;

namespace anot_ai.Services
{
    public interface IAnotacaoRepository
    {
        void CriarNovaAnotacao(NovaAnotacao anotacao);
        List<Anotacao> ListarAnotacoes();

        void DeletarAnotacao(int id);

        void AtualizarAnotacao(int id, AtualizacaoAnotacao atualizacaoAnotacao);

        public Optional<Anotacao> BuscarAnotacaoPorId(int id);

    }
}