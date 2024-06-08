using anot_ai.Data.DTO;
using anot_ai.Models;

namespace anot_ai.Mapper
{
    public class AnotacaoMapper
    {
        public static Anotacao NovaAnotacaoParaAnotacao(NovaAnotacao nova)
        {
            return new Anotacao()
            {
                DataCriacao = new DateTime(),
                DataPrazo = nova.DataPrazo,
                Descricao = nova.Descricao

            };
        }
    }
}
