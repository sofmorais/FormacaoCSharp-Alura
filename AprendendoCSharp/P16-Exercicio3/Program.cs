public class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 16 - Exercício Fatorial");
        Console.WriteLine("Imprima os fatoriais de 1 a 10.");

        int fatorial = 1;

        for (int i = 1; i <= 10; i++)
        {
            fatorial *= i;
            Console.WriteLine($"O fatorial de {i} é = {fatorial}");
        }
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

