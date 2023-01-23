using System;

namespace Mission3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!"); // Welcome user

            char[][] gameBoard = new char[3][]; // Create game board

            gameBoard[0] = new char[] { '1', '2', '3' };
            gameBoard[1] = new char[] { '4', '5', '6' };
            gameBoard[2] = new char[] { '7', '8', '9' };


            Console.WriteLine("Please enter the number to place the 'X': ");

        }
    }
}
