namespace anot_ai.Data.DTO
{
    public class AnotacaoDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataPrazo { get; set; }
        public SmartDTO Smart { get; set; }
        public MonitoramentoDTO Monitoramento { get; set; }
        public PlanoAcaoDTO PlanoAcao { get; set; }

    }
}
