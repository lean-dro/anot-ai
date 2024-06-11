using System.ComponentModel.DataAnnotations;

namespace anot_ai.Data.DTO
{
    public class NovaAnotacao
    {
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime DataPrazo { get; set; }
       
    }
  
}
