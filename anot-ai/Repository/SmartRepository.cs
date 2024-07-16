using anot_ai.Data;
using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Models;
using Microsoft.EntityFrameworkCore;

namespace anot_ai.Repository
{
    public class SmartRepository : ISmartRepository
    {
        private AnotacaoContext _context { get; set; }

        public SmartRepository(AnotacaoContext context)
        {
            _context = context;
        }

        public Smart? BuscarSmartPeloId(int id)
        {
            var lista = ListarSmarts();
            var busca = lista.Find(s => s.Id == id);
            return busca;
        }

        public List<Smart> ListarSmarts()
        {
            return _context.Smarts.ToList();
        }

        public void Criar(Anotacao anotacao, SmartSimples novo)
        {
            if (anotacao.Smart != null)
            {
                _context.Remove(anotacao.Smart);
            }
            Smart smart = SmartMapper.ParaEntidade(novo);
            smart.Anotacao = anotacao;
            smart.AnotacaoId = anotacao.Id;
            _context.Smarts.Add(smart);
            _context.SaveChanges();
        }

        public void Atualizar(int id, SmartSimples atualizacao)
        {
            Smart smart = BuscarSmartPeloId(id);
            smart.Specific = atualizacao.Specific;
            smart.Measurable = atualizacao.Measurable;
            smart.Achievable = atualizacao.Achievable;
            smart.Relevant = atualizacao.Relevant;
            smart.Time = atualizacao.Time;
            _context.SaveChanges();
        }

        public void Excluir(Smart smart)
        {
            _context.Remove(smart);
            _context.SaveChanges();

        }
    }
}
