namespace bytebank_ADM.Colaboradores
{
    public abstract class Colaborador
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalColaboradores { get; private set; }

        public Colaborador(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalColaboradores++;
            Console.WriteLine("Criando um colaborador...");
        }
       

        // Métodos abstratos não tem implementação, apenas definição (assinatura e tipo de retorno)
        // Todas as classes filhas implementarão esse comportamento
        public abstract double GetBonificacao(); 
        public abstract void AumentoSalarial();
    }
}
