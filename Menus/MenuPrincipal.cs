using QuizSeries.Menus.Series.GameOfThrones;

namespace QuizSeries.Menus
{
    public static class MenuPrincipal
    {
        public static void MenuInicial()
        {
            string LogoPrincipal = (@"
░░█ █▀█ █▀▀ █▀█   █▀▄ ▄▀█ █▀   █▀ █▀▀ █▀█ █ █▀▀ █▀
█▄█ █▄█ █▄█ █▄█   █▄▀ █▀█ ▄█   ▄█ ██▄ █▀▄ █ ██▄ ▄█");

            Console.Clear();

            Console.WriteLine(LogoPrincipal);
            Console.WriteLine("\nEscolha uma Serie para realizar o QUIZ:\n");
            Console.WriteLine("1 - Game Of Thrones");
            Console.WriteLine("2 - Suits");
            Console.WriteLine("3 - Vikings");
            Console.WriteLine("0 - Sair do jogo...");

            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    {
                        QuizGot.GameOfThrones();
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
    }
}