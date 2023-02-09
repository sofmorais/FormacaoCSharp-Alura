public class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        //Variáveis do tipo char

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        //Variáveis do tipo string

        string fraseUm = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(fraseUm);

        string vazia = "";
        Console.WriteLine(vazia);
        
        string cursos = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos);
            
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}