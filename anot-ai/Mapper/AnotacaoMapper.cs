using anot_ai.Data.DTO;
using anot_ai.Models;
using anot_ai.Services;

namespace anot_ai.Mapper
{
    public class AnotacaoMapper
    {
        
        public static Anotacao NovaAnotacaoParaEntidade(NovaAnotacao nova)
        {
            GeminiService geminiService = new GeminiService();
            var smart = geminiService.ObterSmart(nova.Descricao, nova.DataPrazo).Result;


            return new Anotacao()
            {
                DataCriacao = new DateTime(),
                DataPrazo = nova.DataPrazo,
                Descricao = nova.Descricao,
                Smart = SmartMapper.ParaEntidade(smart.Smart),
                PlanoAcao = PlanoAcaoMapper.ParaEntidade(smart.PlanoAcao),
                Monitoramento = MonitoramentoMapper.ParaEntidade(smart.Monitoramento)
            };
        }

        

        public static void AtualizarAnotacao(ref Anotacao anotacao, AtualizacaoAnotacao atualizacao)
        {
         
        }
    }
}
