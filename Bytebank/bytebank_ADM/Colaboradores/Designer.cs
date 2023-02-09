namespace bytebank_ADM.Colaboradores
{
    public class Designer : Colaborador
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void AumentoSalarial()
        {
            this.Salario *= 1.11;
        }
    }
}
