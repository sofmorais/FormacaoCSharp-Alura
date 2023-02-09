namespace bytebank_ADM.SistemaInterno
{
    public interface IAutenticacao 
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Autenticar(string login, string senha);
    }
}
