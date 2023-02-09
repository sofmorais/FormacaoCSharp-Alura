using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Comercial
{
    public class ParceiroComercial : IAutenticacao
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public  bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
