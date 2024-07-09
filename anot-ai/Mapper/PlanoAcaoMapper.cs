using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Mapper
{
    public class PlanoAcaoMapper
    {

        public static PlanoAcao ParaEntidade(PlanoAcaoDTO dto)
        {
            PlanoAcao plano = new PlanoAcao();

            for (int i = 0; i < dto.Etapas.Count; i++)
            {
                plano.Etapas.Add(new Etapa()
                {
                    NumeroEtapa = dto.Etapas[i].NumeroEtapa,
                    Acao = dto.Etapas[i].Acao,
                    Detalhes = dto.Etapas[i].Detalhes,
                });
            }
            return plano;
        }


        public static PlanoAcaoDTO ParaDTO(PlanoAcao planoAcao)
        {
            PlanoAcaoDTO plano = new PlanoAcaoDTO();

            for (int i = 0; i < planoAcao.Etapas.Count; i++)
            {
                plano.Etapas.Add(new EtapaDTO()
                {
                    NumeroEtapa = planoAcao.Etapas[i].NumeroEtapa,
                    Acao = planoAcao.Etapas[i].Acao,
                    Detalhes = planoAcao.Etapas[i].Detalhes,
                });
            }
            return plano;
        }
    }
}
