using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Mapper
{
    public class MonitoramentoMapper
    {

        public static Monitoramento ParaEntidade(MonitoramentoDTO dto)
        {

            return new Monitoramento()
            {
                Check = dto.Check
            };

        }
        public static Monitoramento ParaEntidade(MonitoramentoSimples monitoramento)
        {

            return new Monitoramento()
            {
                Check = monitoramento.Check
            };

        }
        public static MonitoramentoDTO ParaDTO(Monitoramento monitoramento)
        {
            return new MonitoramentoDTO()
            {
                Id = monitoramento.Id,
                Check = monitoramento.Check
            };
        }

    }
}
