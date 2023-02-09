namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticacao colaborador, string login, string senha) 
        {
            bool usuarioAutenticado = colaborador.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine($"Boas vindas ao nosso sistema, {colaborador.Nome}.");
                return true;  
            }
            else
            {
                Console.WriteLine("Você não tem acesso ao sistema.");
                return false;
            }
        }
    }
}
