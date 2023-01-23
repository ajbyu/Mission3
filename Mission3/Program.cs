using System;

namespace Mission3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] gameBoard = new char[][]
            {
            new char[] { 'x', 'o', 'o' },
            new char[] { 'x', 'o', 'o' },
            new char[] { 'x', 'o', 'o' }
            };

            BoardInfo.PrintBoard(gameBoard);
        }
    }
}
