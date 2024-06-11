using anot_ai.Data;
using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Models;
using anot_ai.Repository;

namespace anot_ai.Services
{
    public class AnotacaoRepository : IAnotacaoRepository
    {
        private ISmartRepository _smartRepository { get; set; }

        private AnotacaoContext _context { get; set; }

        public AnotacaoRepository(AnotacaoContext dbContext, ISmartRepository smartRepository)
        {
            _context = dbContext;
            _smartRepository = smartRepository;
        }

        public bool CriarNovaAnotacao(NovaAnotacao novaAnotacao)
        {
            Anotacao anotacao = AnotacaoMapper.NovaAnotacaoParaAnotacao(novaAnotacao);
            _context.Anotacoes.Add(anotacao);
            return _context.SaveChanges() > 0;
        }

        public List<Anotacao> ListarAnotacoes()
        {
            Console.WriteLine(_context.DbPath);
            return _context.Anotacoes.ToList();
        }

        public void DeletarAnotacao(int id)
        {
            throw new NotImplementedException();
        }

        public void AtualizarAnotacao(int id, AtualizacaoAnotacao atualizacaoAnotacao)
        {
             var anotacao = BuscarAnotacaoPorId(id);
          

             AnotacaoMapper.AtualizarAnotacao(ref anotacao, atualizacaoAnotacao);

             _context.SaveChanges();
           
        }


        public void Limpar()
        {
            _context.RemoveRange(_context.Anotacoes);
            _context.SaveChanges();
        }
       

        public Anotacao? BuscarAnotacaoPorId(int id)
        {
            var busca = _context.Anotacoes.ToList().Find(anotacao => anotacao.Id == id);
            return busca;
        }
    }
}
