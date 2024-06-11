using anot_ai.Models;
using System.Text.Json.Serialization;

namespace anot_ai.Data.DTO
{
    public class SmartCompleto
    {
        [JsonPropertyName("Smart")]
        SmartDTO Smart { get; set; }

        [JsonPropertyName("Monitoramento")]
        MonitoramentoDTO Monitoramento { get; set; }

        [JsonPropertyName("PlanoAcao")]
        PlanoAcaoDTO PlanoAcao { get; set; }

    }
}
