using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBO_Morpion
{
    internal class Game
    {
        public int CurseurX { get; set; }
        public int CurseurY { get; set; }
        public char JoueurActif { get; set; }
        public char[,] Data { get; set; }
        public Game()
        {
            CurseurX = CurseurY = 1;
            JoueurActif = 'X';
            Data = new char[3, 3];
        }
        public void Affichage() //Fait carré vert de 3 de haut pour 9 de large
        {
            Console.Clear();
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
            /*Le premier chiffre définit la position par défaut, 
             * le chiffre multiplié définit l'empattement de chaque cellule, 
             * la variable définit la cellule qu'on veut colorer
             */
            ColorGrid();
            MarqueurGrid();

            Console.SetCursorPosition(1, 20);
        }
        public void ColorGrid()
        {
            int x = 1 + (10 * CurseurX);
            int y = 3 + (4 * CurseurY);

            Console.BackgroundColor = ConsoleColor.Green;//Affiche la couleur vert
            for (int h = 0; h < 3; h++)
            {
                Console.SetCursorPosition(x, y + h);
                Console.Write(new String(' ', 9));//Répéte un caractére x fois
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void MarqueurGrid()
        {
            for (int h = 0; h < 3; h++)
            {
                for (int w = 0; w < 3; w++)
                {
                    int x = 1 + 4 + (10 * h);
                    int y = 3 + 1 + (4 * w);
                    Console.SetCursorPosition(x, y);
                    Console.Write(Data[h, w]);
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void DeplacerGauche()
        {
            CurseurX = Math.Max(0, CurseurX - 1);
            ColorGrid();
        }
        public void DeplacerDroite()
        {
            CurseurX = Math.Min(2, CurseurX + 1);
            ColorGrid();
        }
        public void DeplacerHaut()
        {
            CurseurY = Math.Max(0, CurseurY - 1);
            ColorGrid();
        }
        public void DeplacerBas()
        {
            CurseurY = Math.Min(2, CurseurY + 1);
            ColorGrid();
        }
        public void PlacerMarqueur()
        {
            if (!char.IsLetter(Data[CurseurX, CurseurY]))
            {
                Data[CurseurX, CurseurY] = JoueurActif;
                if (JoueurActif == 'X')
                    JoueurActif = 'O';
                else
                    JoueurActif = 'X';
            }
        }
        public bool Victoire()
        {
            for (int h = 0; h < 3; h++)
            {
                for (int w = 0; w < 3; w++)
                {
                    if ($"{Data[h, 0]}{Data[h, 1]}{Data[h, 2]}" == "XXX" || $"{Data[0, w]}{Data[1, w]}{Data[2, w]}" == "XXX" || $"{Data[0, 0]}{Data[1, 1]}{Data[2, 2]}" == "XXX")
                    {
                        Console.WriteLine("Gagnant X");
                        return true;
                    }
                    else if ($"{Data[h, 0]}{Data[h, 1]}{Data[h, 2]}" == "OOO" || $"{Data[0, w]}{Data[1, w]}{Data[2, w]}" == "OOO" || $"{Data[0, 0]}{Data[1, 1]}{Data[2, 2]}" == "OOO")
                    {
                        Console.WriteLine("Gagnant O");
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
