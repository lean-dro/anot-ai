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
            Anotacao anotacao = AnotacaoMapper.NovaAnotacaoParaEntidade(novaAnotacao);
            _context.Anotacoes.Add(anotacao);
            return _context.SaveChanges() > 0;
        }

        public List<Anotacao> ListarAnotacoes()
        {
            var anotacoes = _context.Anotacoes.ToList();
            var smarts = _context.Smarts.ToList();
            var etapas = _context.Etapas.ToList();
            var planos = _context.PlanosAcao.ToList();
            var monitoramentos = _context.Monitoramentos.ToList();

            var listaRelacionada =
                from a in anotacoes
                join s in smarts on a.Id equals s.AnotacaoId
                join m in monitoramentos on a.Id equals m.AnotacaoId
                select a;

            var lista = listaRelacionada.ToList();

            return lista;
        }

        public void DeletarAnotacao(Anotacao anotacao)
        {
            _context.Remove(anotacao);
            _context.SaveChanges();
        }

        public void AtualizarAnotacao(int id, AtualizacaoAnotacaoSimples atualizacaoAnotacao)
        {
             var anotacao = BuscarAnotacaoPorId(id);


            anotacao.DataPrazo = atualizacaoAnotacao.DataPrazo;
            anotacao.Descricao = atualizacaoAnotacao.Descricao;

             _context.SaveChanges();
        }
        public void AtualizarAnotacaoComIA(int id, AtualizacaoAnotacaoSimples atualizacaoAnotacao)
        {
            var anotacao = BuscarAnotacaoPorId(id);
            _context.Remove(anotacao.Smart);
            _context.Remove(anotacao.PlanoAcao);
            _context.Remove(anotacao.Monitoramento);

            anotacao.DataPrazo = atualizacaoAnotacao.DataPrazo;
            anotacao.Descricao = atualizacaoAnotacao.Descricao;

            SmartCompleto smart = new GeminiService().ObterSmart(anotacao.Descricao, anotacao.DataPrazo).Result;
            anotacao.Smart = SmartMapper.ParaEntidade(smart.Smart);
            anotacao.PlanoAcao = PlanoAcaoMapper.ParaEntidade(smart.PlanoAcao);
            anotacao.Monitoramento = MonitoramentoMapper.ParaEntidade(smart.Monitoramento);
           
            _context.SaveChanges();
        }

        public void Limpar()
        {
            _context.RemoveRange(_context.Anotacoes);
            _context.SaveChanges();
        }
       

        public Anotacao? BuscarAnotacaoPorId(int id)
        {
            var busca = ListarAnotacoes().Find(a=>a.Id==id);
            
            return busca;
        }
   
    }
}
