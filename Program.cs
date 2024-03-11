using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        string LogoPrincipal = (@"
░░█ █▀█ █▀▀ █▀█   █▀▄ ▄▀█ █▀   █▀ █▀▀ █▀█ █ █▀▀ █▀
█▄█ █▄█ █▄█ █▄█   █▄▀ █▀█ ▄█   ▄█ ██▄ █▀▄ █ ██▄ ▄█");

        Console.Clear();
        System.Console.WriteLine(LogoPrincipal);
        System.Console.WriteLine("\nEscolha uma Serie para realizar o QUIZ:\n");
        System.Console.WriteLine("1 - Game Of Thrones");
        System.Console.WriteLine("2 - Suits");
        System.Console.WriteLine("3 - Vikings");
        System.Console.WriteLine("0 - Sair do jogo...");

        int resposta = int.Parse(Console.ReadLine());

        switch (resposta)
        {
            case 1:
                {
                    QuizGot();
                }
                break;
            case 2:
                {
                }
                break;
            case 3:
                {
                }
                break;
            default:
                {
                }
                break;


        }


    }
    public static void QuizGot()
    {
        string LogoGot = (@"
█▀▀ ▄▀█ █▀▄▀█ █▀▀   █▀█ █▀▀   ▀█▀ █░█ █▀█ █▀█ █▄░█ █▀▀ █▀
█▄█ █▀█ █░▀░█ ██▄   █▄█ █▀░   ░█░ █▀█ █▀▄ █▄█ █░▀█ ██▄ ▄█");

        Console.Clear();
        System.Console.WriteLine(LogoGot);
        System.Console.WriteLine("\nSinopse da série:\n");
        System.Console.WriteLine("Sucesso entre os livros mais vendidos, a série de obras 'A Song of Ice and Fire', de George R.R. Martin, é levada à tela quando HBO decide navegar a fundo pelo gênero e recriar a fantasia medieval épica. Este é o retrato de duas famílias poderosas - reis e rainhas, cavaleiros e renegados, homens honestos e mentirosos - disputando um jogo mortal pelo controle dos Sete Reinos de Westeros para assumir o Trono de Ferro. A série foi filmada em Malta e no norte da Irlanda, tendo participação do escritor dos livros.");

        System.Console.WriteLine("\nPrecione qualquer tecla para iniciar o Quiz:");
        Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine(LogoGot);
        Got1();
        void Got1()
        {
            System.Console.WriteLine(" Quem é o bastardo de Ned Stark?");
            System.Console.WriteLine("1 - Tyrion Lanister");
            System.Console.WriteLine("2 - Perdigueiro, O cão");
            System.Console.WriteLine("3 - John Snow, Lord Comandante da Guarda da noite");
            int resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    System.Console.WriteLine("Ele não é filho do ned, aperte qualquer tecla para escolher outra opção:");
                    Console.ReadLine();
                    Got1();
                    break;
                case 2:
                    System.Console.WriteLine("Ele não é filho do ned, aperte qualquer tecla para escolher outra opção:");
                    Console.ReadLine();
                    Got1();
                    break;
                case 3:
                    System.Console.WriteLine("Parabéns!!!! Aperte qualquer tecla para a proxima pergunta");
                    Console.ReadLine();
                    Got2();
                    break;

            }
            void Got2()
            {

            }

        }
    }
}
