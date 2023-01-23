using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public static class BoardInfo
    {
        public static void PrintBoard(char[][] gameBoard)
        {
            Console.WriteLine("Game Board");
            Console.WriteLine("-------");
            foreach (var line in gameBoard)
            {
                Console.Write("|");
                foreach (var entry in line)
                {
                    Console.Write(entry);
                    Console.Write('|');
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("-------");
        }
    }
}
