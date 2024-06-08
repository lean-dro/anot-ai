using Microsoft.EntityFrameworkCore;

namespace anot_ai.Models
{
    public class Anotacao
    {
    
        public int AnotacaoId { get; set; }
        public string Descricao { get; set; }     
        public DateTime DataPrazo { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}
