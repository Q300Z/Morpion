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

            int x = 0;
            int y = 0;

            //ColorGrid([1,11,21],[3,7,11])
            ColorGrid(1+(10*x), 3+(y*4));//Le premier chiffre définit la position par défaut, le chiffre multiplié définit l'empattement de chaque cellule, la variable définit la cellule qu'on veut colorer

            Console.SetCursorPosition(1, 25);
        }
        static void ColorGrid(int x, int y) //Fait carré vert de 3 de haut pour 9 de large
        {
            Console.BackgroundColor = ConsoleColor.Green;
            for (int h = 0; h < 3; h++)
            {
                for (int l = 0; l < 9; l++)
                {
                    Console.SetCursorPosition(x + l, y + h);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}                           