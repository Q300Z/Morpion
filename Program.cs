namespace TBO_Morpion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Affichage();

            while (true)
            {

                var key = Console.ReadKey(true);

                /*//If
                if (key.Key == ConsoleKey.DownArrow)
                {
                    game.DeplacerBas();
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    game.DeplacerHaut();
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    game.DeplacerGauche();
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    game.DeplacerDroite();
                }
                else if (key.Key == ConsoleKey.Spacebar)
                {
                    game.PlacerCroix();
                }
                */

                //Switch
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        game.DeplacerHaut();
                        break;
                    case ConsoleKey.DownArrow:
                        game.DeplacerBas();
                        break;
                    case ConsoleKey.LeftArrow:
                        game.DeplacerGauche();
                        break;
                    case ConsoleKey.RightArrow:
                        game.DeplacerDroite();
                        break;
                    case ConsoleKey.Spacebar:
                        game.PlacerMarqueur();
                        break;
                    default: break;
                }
                game.Affichage();

                Console.WriteLine(game.Victoire());
            }
        }
    }
}