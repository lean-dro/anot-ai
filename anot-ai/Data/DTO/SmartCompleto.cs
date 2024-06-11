using anot_ai.Models;
using System.Text.Json.Serialization;

namespace anot_ai.Data.DTO
{
    public class SmartCompleto
    {
        public SmartCompleto()
        {
            Smart = new SmartDTO();
            Monitoramento = new MonitoramentoDTO();
            PlanoAcao = new PlanoAcaoDTO();
        }

        [JsonPropertyName("smart")]
        public SmartDTO Smart { get; set; }

        [JsonPropertyName("monitoramento")]
        public MonitoramentoDTO Monitoramento { get; set; }

        [JsonPropertyName("planoAcao")]
        public PlanoAcaoDTO PlanoAcao { get; set; }

    }
}
