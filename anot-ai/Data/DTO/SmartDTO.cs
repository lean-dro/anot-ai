using System.Text.Json.Serialization;

namespace anot_ai.Data.DTO
{
    public class SmartDTO
    {
        public int Id { get; set; }
        
        public string Specific { get; set; }
        public string Measurable { get; set; }
        public string Achievable { get; set; }
        public string Relevant { get; set; }
        public string Time { get; set; }
    }
}
