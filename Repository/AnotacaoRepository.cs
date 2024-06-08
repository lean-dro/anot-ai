using anot_ai.Data;
using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace anot_ai.Services
{
    public class AnotacaoRepository : IAnotacaoRepository
    {

        private AnotacaoContext _context { get; set; }

        public AnotacaoRepository(AnotacaoContext dbContext)
        {
            _context = dbContext;
        }

        public void CriarNovaAnotacao(NovaAnotacao novaAnotacao)
        {
            Anotacao anotacao = AnotacaoMapper.NovaAnotacaoParaAnotacao(novaAnotacao);
            _context.Add(anotacao);
            _context.SaveChanges();
        }

        public List<Anotacao> ListarAnotacoes()
        {
            return _context.Anotacoes.ToList();
        }

        public void DeletarAnotacao(int id)
        {
            throw new NotImplementedException();
        }

        public void AtualizarAnotacao(int id, AtualizacaoAnotacao atualizacaoAnotacao)
        {
           
        }

       

        public Optional<Anotacao> BuscarAnotacaoPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
