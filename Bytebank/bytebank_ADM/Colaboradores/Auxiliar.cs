namespace bytebank_ADM.Colaboradores
{
    public class Auxiliar : Colaborador
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        public override void AumentoSalarial()
        {
            this.Salario *= 1.1;
        }
    }
}
