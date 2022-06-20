using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project_smartfrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 40);
            Random rand = new Random();
            ConsoleColor[] Color = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Yellow, ConsoleColor.Gray };

            while (true)
            {
                Console.Clear();
                for(int i = 0; i<30; i++)
                {
                    Console.ForegroundColor = Color[rand.Next(6)];
                    Console.SetCursorPosition(rand.Next(100), rand.Next(40));
                    Console.Write("Hello world");
                }
                Thread.Sleep(200);
            }
        }
    }
}
