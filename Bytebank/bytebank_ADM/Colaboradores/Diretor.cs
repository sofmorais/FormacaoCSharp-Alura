namespace bytebank_ADM.Colaboradores
{
    public class Diretor : ColaboradorAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando um diretor...");
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public override void AumentoSalarial()
        {
            this.Salario *= 1.15;
        }
    }
}
