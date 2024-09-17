using System;

class Program
{
    static void Main()
    {
        int x = 0, y = 0;
        ConsoleKey gomb;
        int ww = Console.WindowWidth;
        int wh = Console.WindowHeight;

        while (true)
        {
            Console.SetCursorPosition(x, y);
            gomb = Console.ReadKey(true).Key;

            if (gomb == ConsoleKey.UpArrow && y > 0) y--;
            if (gomb == ConsoleKey.DownArrow && y < wh - 1) y++;
            if (gomb == ConsoleKey.LeftArrow && x > 0) x--;
            if (gomb == ConsoleKey.RightArrow && x < ww - 1) x++;

            if (gomb == ConsoleKey.D1)
            {Console.ForegroundColor = ConsoleColor.Red;}
            if (gomb == ConsoleKey.D2)
            {Console.ForegroundColor = ConsoleColor.Green;}
            if (gomb == ConsoleKey.D3)
            { Console.ForegroundColor = ConsoleColor.Blue;}
            if (gomb == ConsoleKey.D4)
            { Console.ForegroundColor = ConsoleColor.Gray; }

            if (gomb == ConsoleKey.Spacebar)
            {
                Console.SetCursorPosition(x, y);
                Console.Write('█');
            }

            if (gomb == ConsoleKey.Tab)
            {

                while (true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write('█');

                    gomb = Console.ReadKey(true).Key;

                    if (gomb == ConsoleKey.UpArrow && y > 0) y--;
                    if (gomb == ConsoleKey.DownArrow && y < wh - 1) y++;
                    if (gomb == ConsoleKey.LeftArrow && x > 0) x--;
                    if (gomb == ConsoleKey.RightArrow && x < ww - 1) x++;

                    if (gomb == ConsoleKey.Spacebar) break;
                }
            }

            if (gomb == ConsoleKey.C)
            {
                Console.Clear();
                x = 0;
                y = 0;
            }

            if(gomb == ConsoleKey.R)
            {
                Console.ResetColor();
            }
            if (gomb == ConsoleKey.Escape) break;
        }
    }
}