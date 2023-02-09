public class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool estaAcompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (estaAcompanhado == true)
        {
            textoAdicional = "João está acompanhado.";
        }
        else
        {
            textoAdicional = "João não está acompanhado.";
        }

        if (idadeJoao >= 18 || estaAcompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}