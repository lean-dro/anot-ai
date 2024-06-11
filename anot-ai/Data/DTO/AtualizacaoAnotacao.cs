using anot_ai.Models;

namespace anot_ai.Data.DTO
{
    public class AtualizacaoAnotacao
    {
        public string Descricao { get; set; }
        public DateTime DataPrazo { get; set; }
        public SmartDTO Smart { get; set; }
        public PlanoAcaoDTO PlanoAcao { get; set; }
        public MonitoramentoDTO Monitoramento { get; set; }
    }
}
