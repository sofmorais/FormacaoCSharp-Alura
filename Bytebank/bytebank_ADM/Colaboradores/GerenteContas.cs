namespace bytebank_ADM.Colaboradores
{
    public class GerenteContas : ColaboradorAutenticavel
    {
        public GerenteContas(string cpf) : base(cpf, 4000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentoSalarial()
        {
            this.Salario *= 1.05;
        }
    }
}
