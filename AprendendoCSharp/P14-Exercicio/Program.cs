public class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 14 - Exercício Imposto de Renda");
        Console.WriteLine("Calcule o Imposto de Renda de acordo com a alíquota.");
        Console.WriteLine();

        Console.WriteLine("Qual é o seu salário?");
        double salario = Convert.ToDouble(Console.ReadLine());

        // IR: (salario  * aliquota) - valor a ser deduzido
        double isencao = 0;
        double calculoImpostoUm = salario * 0.075 - 142.80;
        double calculoImpostoDois = salario * 0.150 - 354.80;
        double calculoImpostoTres = salario * 0.225 - 636.13;
        double calculoImpostoQuatro = salario * 0.275 - 869.36;

        if (salario < 1903.98)
        {
            Console.WriteLine($"Você está isento. Seu IR é de R${isencao}.");
        }
        else if (salario > 1903.98 && salario <= 28326.65)
        {
            Console.WriteLine($"O seu IR é de R${(float)calculoImpostoUm}.");
        }
        else if (salario > 2826.66 && salario <= 3751.05)
        {
            Console.WriteLine($"O seu IR é de R${((float)calculoImpostoDois)}.");
        }
        else if (salario > 3751.06 && salario <= 4664.68)
        {
            Console.WriteLine($"O seu IR é de R${((float)calculoImpostoTres)}.");
        }
        else if (salario >= 4664.68)
        {
            Console.WriteLine($"O seu IR é de R${((float)calculoImpostoQuatro)}.");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}