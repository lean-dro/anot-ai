using anot_ai.Data;
using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Models;
using Microsoft.EntityFrameworkCore;

namespace anot_ai.Services
{
    public class AnotacaoRepository : IAnotacaoRepository
    {

        private AnotacaoContext _context { get; set; }

        public AnotacaoRepository(AnotacaoContext dbContext)
        {
            _context = dbContext;
        }

        public void criarNovaAnotacao(NovaAnotacao novaAnotacao)
        {
            Anotacao anotacao = AnotacaoMapper.NovaAnotacaoParaAnotacao(novaAnotacao);
            _context.Add(anotacao);
            _context.SaveChanges();
        }

        public List<Anotacao> listarAnotacoes()
        {
            return _context.Anotacoes.ToList();
        }
    }
}
