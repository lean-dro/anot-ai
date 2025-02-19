﻿using anot_ai.Data;
using anot_ai.Data.DTO;
using anot_ai.Mapper;
using anot_ai.Models;
using anot_ai.Repository;
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

        public bool Criar(NovaAnotacao novaAnotacao)
        {
            Anotacao anotacao = AnotacaoMapper.NovaAnotacaoParaEntidade(novaAnotacao);
            _context.Anotacoes.Add(anotacao);
            return _context.SaveChanges() > 0;
        }

        public List<Anotacao> ListarAnotacoes()
        {

            var anotacoes = _context.Anotacoes.ToList() ;
            var smarts = _context.Smarts.ToList();
            var etapas = _context.Etapas.ToList();
            var planos = _context.PlanosAcao.ToList();
            var monitoramentos = _context.Monitoramentos.ToList();

           

            return anotacoes;
        }

        public void Excluir(Anotacao anotacao)
        {
            _context.Remove(anotacao);
            _context.SaveChanges();
        }

        public void Atualizar(int id, AtualizacaoAnotacaoSimples atualizacaoAnotacao)
        {
             var anotacao = BuscarAnotacaoPeloId(id);


            anotacao.DataPrazo = atualizacaoAnotacao.DataPrazo;
            anotacao.Descricao = atualizacaoAnotacao.Descricao;

             _context.SaveChanges();
        }
        public void AtualizarComIA(int id, AtualizacaoAnotacaoSimples atualizacaoAnotacao)
        {
            var anotacao = BuscarAnotacaoPeloId(id);
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
       

        public Anotacao? BuscarAnotacaoPeloId(int id)
        {
            var busca = ListarAnotacoes().Find(a=>a.Id==id);
            
            return busca;
        }
   
    }
}
