using anot_ai.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace anot_ai.Testes.Services
{
    public class GeminiServiceTest
    {
      [Fact]
      public async void TestaSeConsultaNoGeminiRetornou()
      {
            GeminiService service = new GeminiService();

            var resultado = await service.ObterSmart("Testar minha api", DateTime.Now);

            Assert.NotNull(resultado);
      }
    }
}
