using bytebank_ADM.Colaboradores;
using bytebank_ADM.Comercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region 
//// Criando colaboradores e exibindo suas bonificações
//Colaborador pedro = new Colaborador("98712354678", 2000);
//pedro.Nome = "Pedro Melo";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine($"A bonificação de Pedro é: R$ {pedro.GetBonificacao()}");
//Console.WriteLine();

//Diretor roberta = new Diretor("09718735690");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine($"A bonificação de Roberta é: R$ {roberta.GetBonificacao()}");
//Console.WriteLine();

//// Gerenciador criado para exibir o total de bonificações 
//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine($"O total de bonificações é: R$ {gerenciador.TotalBonificacao}");
//Console.WriteLine($"O total de colaboradores é: {Colaborador.TotalColaboradores}");
//Console.WriteLine();

//// Definição e exibição dos novos salários
//Console.WriteLine("Registrando os novos salários...");
//roberta.AumentoSalarial();
//pedro.AumentoSalarial();

//Console.WriteLine($"O novo salário da Roberta é: R$ {roberta.Salario}");
//Console.WriteLine($"O novo salário do Pedro é: R$ {pedro.Salario}");

#endregion

public class Program
{
    public static void Main(string[] args)
    {
        //CalcularBonificacao();
        AcessarSistema();

        void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer ulisses = new Designer("07687634510");
            ulisses.Nome = "Ulisses Souza";

            Diretor paula = new Diretor("07663527364");
            paula.Nome = "Paula Souza";

            Auxiliar igor = new Auxiliar("02638746532");
            igor.Nome = "Igor Dias";

            GerenteContas camila = new GerenteContas("98765434216");
            camila.Nome = "Camila Oliveira";

            gerenciador.Registrar(ulisses);
            gerenciador.Registrar(paula);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine($"O total de bonificação é: R$ {gerenciador.TotalBonificacao}");
        }

        void AcessarSistema()
        {
            SistemaInterno acesso = new SistemaInterno();

            Diretor ingrid = new Diretor("29848598342");
            ingrid.Nome = "Ingrid Souza";
            ingrid.Login = "ingrid@email.com";
            ingrid.Senha = "123";

            GerenteContas carla = new GerenteContas("123764897190");
            carla.Nome = "Carla Melo";
            carla.Login = "carla@email.com";
            carla.Senha = "321";


            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Nome = "Parceiro Comercial Um";
            parceiro.Login = "parceiro@email.com";
            parceiro.Senha = "321";


            acesso.Logar(ingrid, ingrid.Login, ingrid.Senha);
            acesso.Logar(carla, carla.Login, carla.Senha);
            acesso.Logar(parceiro, parceiro.Login, parceiro.Senha);

            string mensagem = "ententendo como manupular strings com c#";

            Console.WriteLine("Primeira ocorrencia do caractere = " + mensagem.IndexOf("c"));
            Console.WriteLine("Última ocorrencia do caractere = " + mensagem.LastIndexOf("c"));
        }
    }
}