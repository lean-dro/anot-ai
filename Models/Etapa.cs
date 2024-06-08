namespace anot_ai.Models
{
    public class Etapa
    {
        public int Id { get; set; }
        public int NumeroEtapa { get; set; }
        public string Acao { get; set; }
        public string Detalhes { get; set; }
        public int PlanoAcaoId { get; set; }
        public PlanoAcao PlanoAcao { get; set; }
    }
}