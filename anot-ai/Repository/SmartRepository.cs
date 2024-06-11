using anot_ai.Data;
using anot_ai.Data.DTO;
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

        public void AtualizarSmart(int id, SmartDTO atualizacaoSmart)
        {
            throw new NotImplementedException();
        }

        public Smart? BuscarSmartPorID(int id)
        {
            var lista = ListarSmarts();
            var busca = lista.Find(s => s.Id == id);
            return busca;
        }

        public bool CriarNovoSmart(Smart smart)
        {
             _context.Smarts.Add(smart);
             return _context.SaveChanges()>0;
        }

        public List<Smart> ListarSmarts()
        {
            return _context.Smarts.ToList();
        }
    }
}
