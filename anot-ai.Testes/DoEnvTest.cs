namespace anot_ai.Testes
{
    public class DoEnvTest
    {
        [Fact]
        public void TestaSeExisteDotEnv()
        {
            Assert.True(Path.Exists(".env"));
        }
        [Fact]
        public void TestaSeHaConteudoNaDotEnv()
        {
            DotNetEnv.Env.Load();
            Assert.Equal("valorTeste", Environment.GetEnvironmentVariable("TESTE"));
        }
    }
}