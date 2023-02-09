using csharp_exception.Contas;

namespace csharp_exception
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

            try
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            catch (IOException)
            {
                Console.WriteLine("Leitura de arquivo interrompida.");
            }
            finally
            {
                leitor.Fechar();
            }

            try
            {
                ContaCorrente conta1 = new ContaCorrente(278, "1234-X");
                conta1.Sacar(50);
                Console.WriteLine(conta1.GetSaldo());
                conta1.Sacar(150);
                Console.WriteLine(conta1.GetSaldo());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
                Console.WriteLine("Não é possível criar uma conta com o número de agência igual a 0.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Operação negada.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}