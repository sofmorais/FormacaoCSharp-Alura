public class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            { 
                if (coluna > linha)
                {
                    break;
                }

                Console.WriteLine(coluna + 1);
            }
            Console.WriteLine();
        }

        // Forma alternativa sem if e break
        for (int linha = 0; linha < 10; linha++)
        {
            for (int coluna = 0; coluna <= linha; coluna++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}