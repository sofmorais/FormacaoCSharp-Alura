using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Colaboradores
{
    public abstract class ColaboradorAutenticavel : Colaborador, IAutenticacao
    {
        protected ColaboradorAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return this.Login == login && this.Senha == senha; 

        }
    }
}
