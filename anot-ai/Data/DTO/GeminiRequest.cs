using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace anot_ai.Data.DTO
{
    public class GeminiRequest
    {
        [JsonPropertyName("contents")]
        public Content contents { get; set; }
        public GeminiRequest(string prompt)
        { 
            contents = new Content(prompt);
        }
    }
    public class Content
    {
        public Content(string prompt)
        {
            parts.Add(new Part(prompt));
        }
        [JsonPropertyName("parts")]
        public List<Part> parts { get; set; } = new List<Part>();
    }

    public class Part{
        public Part(string prompt)
        {
            text = prompt;
        }
        public string text;
    }
}
