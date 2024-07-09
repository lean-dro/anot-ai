using anot_ai.Data.DTO;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace anot_ai.Services
{
    public class GeminiService
    {
        HttpClient cliente { get; set; }
        public GeminiService(){
            cliente = new HttpClient();
        }
        public async Task<SmartCompleto> ObterSmart(string descricao, DateTime prazo)
        {
            try
            {
                var options = new JsonSerializerOptions()
                {
                    IncludeFields = true,
                    PropertyNameCaseInsensitive = true
                };

                DotNetEnv.Env.Load();
                string key = Environment.GetEnvironmentVariable("GEMINI_KEY");
                string prompt = await File.ReadAllTextAsync("./prompt_base.txt", encoding: Encoding.UTF8);
                string requestUri = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key={key}";
                prompt = prompt.Replace("[ATIVIDADE]", descricao);
                prompt = prompt.Replace("[PRAZO]", prazo.ToString("dd/MM/yyyy HH:mm:ss"));
                GeminiRequest geminiRequest = new GeminiRequest(prompt);


                HttpContent body = new StringContent(
                    JsonSerializer.Serialize(geminiRequest, options), 
                    Encoding.UTF8,
                    "application/json"
                );
                var corpoRequisicao = await body.ReadAsStringAsync();
                var resultado = await cliente.PostAsync(
                    requestUri, body
                );

                string corpoResultado = await resultado.Content.ReadAsStringAsync();

             
                JObject jsonObject = JObject.Parse(corpoResultado);
                var smartJson = jsonObject.SelectToken("$.candidates[0].content.parts[0].text").ToString();

                JsonNode jsonDocument = JsonNode.Parse(smartJson);
                

                SmartCompleto smartCompleto = new SmartCompleto();
                var smart = jsonDocument["smart"].Deserialize<SmartDTO>(options);
                var planoAcao = jsonDocument["planoAcao"].Deserialize<PlanoAcaoDTO>(options);
                var monitoramento = jsonDocument["monitoramento"].Deserialize<MonitoramentoDTO>(options);

                smartCompleto.Smart = smart;
                smartCompleto.Monitoramento = monitoramento;
                smartCompleto.PlanoAcao = planoAcao;


                return smartCompleto;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

    }
}
