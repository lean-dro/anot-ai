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
                DataCriacao = DateTime.Now,
                DataPrazo = nova.DataPrazo,
                Descricao = nova.Descricao,
                Smart = SmartMapper.ParaEntidade(smart.Smart),
                PlanoAcao = PlanoAcaoMapper.ParaEntidade(smart.PlanoAcao),
                Monitoramento = MonitoramentoMapper.ParaEntidade(smart.Monitoramento)
            };
        }

        public static AnotacaoDTO ParaDTO(Anotacao anotacao)
        {
            return new AnotacaoDTO()
            {
                Id = anotacao.Id,
                Descricao = anotacao.Descricao,
                DataCriacao = anotacao.DataCriacao,
                DataPrazo = anotacao.DataPrazo,
                Monitoramento = MonitoramentoMapper.ParaDTO(anotacao.Monitoramento),
                Smart = SmartMapper.ParaDTO(anotacao.Smart),
                PlanoAcao = PlanoAcaoMapper.ParaDTO(anotacao.PlanoAcao)
            };
        }

        public static List<AnotacaoDTO> ParaDTO(List<Anotacao> anotacoes)
        {
            List<AnotacaoDTO> anotacoesDTO = new List<AnotacaoDTO>();
            foreach (var anotacao in anotacoes)
            {
                anotacoesDTO.Add(ParaDTO(anotacao));
            }
            return anotacoesDTO;
        }


        public static void AtualizarAnotacao(ref Anotacao anotacao, AtualizacaoAnotacao atualizacao)
        {
         
        }
    }
}
