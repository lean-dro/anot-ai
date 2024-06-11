namespace anot_ai.Models
{
    public class Smart
    {
        public int Id { get; set; }
        public string Specific { get; set; }
        public string Measurable { get; set; }
        public string Achievable { get; set; }
        public string Relevant { get; set; }
        public string Time { get; set; }
        public int AnotacaoId { get; set; }
        public Anotacao Anotacao { get; set; }
    }
}
