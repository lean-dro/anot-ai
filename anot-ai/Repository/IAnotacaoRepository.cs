using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Services
{
    public interface IAnotacaoRepository
    {
        bool Criar(NovaAnotacao anotacao);
        List<Anotacao> ListarAnotacoes();

        void Excluir(Anotacao anotacao);

        void Atualizar(int id, AtualizacaoAnotacaoSimples atualizacaoAnotacao);
        void AtualizarComIA(int id, AtualizacaoAnotacaoSimples atualizacaoAnotacao);
        void Limpar();

        public Anotacao? BuscarAnotacaoPeloId(int id);

    }
}