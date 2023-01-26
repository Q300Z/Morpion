namespace TBO_Morpion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Morpion");
            Console.WriteLine("║ ╗ ╝ ╚ ╔ ═ ╩ ╦ ╬ ╠ ╣");
            
            Console.WriteLine("╔═════════╦═════════╦═════════╗");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("╠═════════╬═════════╬═════════╣");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("╠═════════╬═════════╬═════════╣");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("║         ║         ║         ║");
            Console.WriteLine("╚═════════╩═════════╩═════════╝");

            int x = 2;
            int y = 1;



            //ColorGrid([1,11,21],[3,7,11])
            ColorGrid(x,y);

            Console.SetCursorPosition(1, 25);
        }
        static void ColorGrid(int x, int y) //Fait carré vert de 3 de haut pour 9 de large
        {
            /*Le premier chiffre définit la position par défaut, 
             * le chiffre multiplié définit l'empattement de chaque cellule, 
             * la variable définit la cellule qu'on veut colorer
             */
            x = 1 + (10 * x);
            y = 3 + (4 * y);

            Console.BackgroundColor = ConsoleColor.Green;//Affiche la couleur vert
            for (int h = 0; h < 3; h++)
            {
                Console.SetCursorPosition(x, y + h);
                Console.Write(new String(' ', 9));//Répéte un caractére x fois

                /*for (int l = 0; l < 9; l++)
                {
                    Console.SetCursorPosition(x + l, y + h);
                    Console.Write(" ");
                }*/
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}                           