using anot_ai.Data.DTO;
using anot_ai.Models;
using Microsoft.CodeAnalysis;

namespace anot_ai.Services
{
    public interface IAnotacaoRepository
    {
        bool CriarNovaAnotacao(NovaAnotacao anotacao);
        List<Anotacao> ListarAnotacoes();

        void DeletarAnotacao(int id);

        void AtualizarAnotacao(int id, AtualizacaoAnotacao atualizacaoAnotacao);

        void Limpar();

        public Anotacao? BuscarAnotacaoPorId(int id);

    }
}