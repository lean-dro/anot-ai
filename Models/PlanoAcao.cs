namespace anot_ai.Models
{
    public class PlanoAcao
    {
        public int Id { get; set; }
        public List<Etapa> Etapas { get; set; } = new List<Etapa>();
        public int AnotacaoId { get; set; }
        public Anotacao Anotacao { get; set; }
    }
}