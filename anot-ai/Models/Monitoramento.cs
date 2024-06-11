namespace anot_ai.Models
{
    public class Monitoramento
    {
        public int Id { get; set; }
        public string Check { get; set; }
        public int AnotacaoId { get; set; }
        public Anotacao Anotacao { get; set; }
    }
}