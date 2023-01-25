using System;
using static Mission3.BoardInfo;

namespace Mission3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!"); // Welcome user

            char[][] gameBoard = new char[3][]; // Create game board

            gameBoard[0] = new char[] { 'X', 'O', 'X' };
            gameBoard[1] = new char[] { 'O', 'X', 'O' };
            gameBoard[2] = new char[] { 'O', 'X', 'O' };

            var state = BoardInfo.CheckWin(gameBoard);
            Console.WriteLine(state);
            

        }
    }
}
