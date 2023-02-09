public class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Conversões e Outros Tipos");

        double salario = 3000.15;

        Console.WriteLine($"O salário total é {salario}");

        int salarioInteiro = (int)salario;
        Console.WriteLine($"O salário arredondado é {salarioInteiro}");

        //Tipos de variáveis

        long variavelLong = 20000000000;
        Console.WriteLine(variavelLong);

        short variavelShort = 15000;
        Console.WriteLine(variavelShort);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}