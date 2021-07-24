namespace apicatalogojogos.Controllers.V1.Services.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            :base("Este jogo não está cadastrado")
        {}
    }
}