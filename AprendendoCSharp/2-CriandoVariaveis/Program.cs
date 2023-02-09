public class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade = 27;

        //Conceito de interpolação 
        Console.WriteLine($"Aqui a idade é {idade}");

        idade = 27 - 5;
        Console.WriteLine($"Aqui a idade é {idade}");

        idade = 5 * 2 - 6;
        Console.WriteLine($"Aqui a idade é {idade}");

        idade = (5 - 2) * 3;
        Console.WriteLine($"Aqui a idade é {idade}");

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}