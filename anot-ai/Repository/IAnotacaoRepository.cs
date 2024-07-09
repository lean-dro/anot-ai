using anot_ai.Data.DTO;
using anot_ai.Models;
using Microsoft.CodeAnalysis;

namespace anot_ai.Services
{
    public interface IAnotacaoRepository
    {
        bool CriarNovaAnotacao(NovaAnotacao anotacao);
        List<Anotacao> ListarAnotacoes();

        void DeletarAnotacao(Anotacao anotacao);

        void AtualizarAnotacao(int id, AtualizacaoAnotacaoSimples atualizacaoAnotacao);
        void AtualizarAnotacaoComIA(int id, AtualizacaoAnotacaoSimples atualizacaoAnotacao);
        void Limpar();

        public Anotacao? BuscarAnotacaoPorId(int id);

    }
}