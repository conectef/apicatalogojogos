namespace apicatalogojogos.Controllers.V1.Services.Excepetions
{
    public class JogoJaCadastradoExcepetion : Exception
    {
        public JogoJaCadastradoException()
            : base("Este já jogo está cadastrado")
        { }
    }
}