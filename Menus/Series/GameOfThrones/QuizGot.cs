using System.Threading;
namespace QuizSeries.Menus.Series.GameOfThrones
{
    public class QuizGot
    {
        public static void LogoGot()
        {
            System.Console.WriteLine($@"
█▀▀ ▄▀█ █▀▄▀█ █▀▀   █▀█ █▀▀   ▀█▀ █░█ █▀█ █▀█ █▄░█ █▀▀ █▀
█▄█ █▀█ █░▀░█ ██▄   █▄█ █▀░   ░█░ █▀█ █▀▄ █▄█ █░▀█ ██▄ ▄█");
        }

        public static void GameOfThrones()
        {
            Console.Clear();
            LogoGot();

            Console.WriteLine("\nSinopse da série:\n");
            Console.WriteLine("Sucesso entre os livros mais vendidos, a série de obras 'A Song of Ice and Fire', de George R.R. Martin, é levada à tela quando HBO decide navegar a fundo pelo gênero e recriar a fantasia medieval épica. Este é o retrato de duas famílias poderosas - reis e rainhas, cavaleiros e renegados, homens honestos e mentirosos - disputando um jogo mortal pelo controle dos Sete Reinos de Westeros para assumir o Trono de Ferro. A série foi filmada em Malta e no norte da Irlanda, tendo participação do escritor dos livros.");

            Console.WriteLine("\nPrecione qualquer tecla para iniciar o Quiz:");
            Console.ReadLine();

            Console.Clear();
            LogoGot();
            PrimeiraPerguntaGot();
        }

        public static void PrimeiraPerguntaGot()
        {
            Console.Clear();
            LogoGot();

            System.Console.WriteLine("\nQuem é o bastardo de Ned Stark?\n");
            System.Console.WriteLine("1 - Tyrion Lanister");
            System.Console.WriteLine("2 - Perdigueiro, O cão");
            System.Console.WriteLine("3 - John Snow, Lord Comandante da Guarda da noite");
            int resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("Ele não é filho do ned, aperte qualquer tecla para escolher outra opção:");
                    Console.ReadLine();
                    PrimeiraPerguntaGot();
                    break;
                case 2:
                    Console.Clear();
                    System.Console.WriteLine("Errado, aperte qualquer tecla para escolher outra opção:");
                    Console.ReadLine();
                    PrimeiraPerguntaGot();
                    break;
                case 3:
                    Console.Clear();
                    System.Console.WriteLine("Parabéns!!!! Aperte qualquer tecla para a proxima pergunta");
                    Console.ReadLine();
                    //Got2();
                    break;
                default:
                    Console.Clear();
                    System.Console.WriteLine("Opção invalida, escolha uma das opções exibidas na tela.");
                    Thread.Sleep(3000);

                    PrimeiraPerguntaGot();
                    break;
            }
        }
    }
}
