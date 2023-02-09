public class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento a Longo Prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int prazo = 1; prazo <= 5; prazo++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.001;
        }

        Console.WriteLine($"Depois de 5 anos você terá R$ {investimento}");

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}