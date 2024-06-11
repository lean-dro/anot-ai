using Microsoft.EntityFrameworkCore;

namespace anot_ai.Models
{
    public class Anotacao
    {
    
        public int Id { get; set; }
        public string Descricao { get; set; }     
        public DateTime DataPrazo { get; set; }
        public Smart Smart { get; set; }
        public PlanoAcao PlanoAcao { get; set; }
        public Monitoramento Monitoramento { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}
