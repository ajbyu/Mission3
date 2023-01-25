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

            gameBoard[0] = new char[] { '1', '2', '3' };
            gameBoard[1] = new char[] { '4', '5', '6' };
            gameBoard[2] = new char[] { '7', '8', '9' };

            var state = BoardInfo.CheckWin(gameBoard);

            while (state == GameState.NoWinner)
            {
                bool validInput = false;
                while (validInput == false)
                {
                    Console.Clear();
                    BoardInfo.PrintBoard(gameBoard);
                    Console.WriteLine("Please enter the number to place the 'X': ");
                    string input = Console.ReadLine();
                    char newInput = char.Parse(input);

                    for (int i = 0; i < gameBoard.Length; i++)
                    {
                        for (int j = 0; j < gameBoard[i].Length; j++)
                        {
                            if (gameBoard[i][j] == newInput)
                            {
                                validInput = true;
                                gameBoard[i][j] = 'X';
                                break;
                            }
                            else if (i == gameBoard.Length & j == gameBoard.Length & validInput == false)
                            {
                                Console.WriteLine("Please enter a valid input");
                            }
                        }
                    }
                }

                state = BoardInfo.CheckWin(gameBoard);
                if (state == GameState.NoWinner)
                {
                    validInput = false;
                    while (validInput == false)
                    {
                        Console.Clear();
                        BoardInfo.PrintBoard(gameBoard);
                        Console.WriteLine("Please enter the number to place the 'O': ");
                        string input = Console.ReadLine();
                        char newInput = char.Parse(input);

                        for (int i = 0; i < gameBoard.Length; i++)
                        {
                            for (int j = 0; j < gameBoard[i].Length; j++)
                            {
                                if (gameBoard[i][j] == newInput)
                                {
                                    validInput = true;
                                    gameBoard[i][j] = 'O';
                                    break;
                                }
                                else if (i == gameBoard.Length & j == gameBoard.Length & validInput == false)
                                {
                                    Console.WriteLine("Please enter a valid input");
                                }
                            }
                        }
                    }
                }

                state = BoardInfo.CheckWin(gameBoard);
                if (state == GameState.X)
                {
                    Console.Clear();
                    BoardInfo.PrintBoard(gameBoard);
                    Console.Write("X Wins!\n\n");
                    break;
                }
                else if (state == GameState.O)
                {
                    Console.Clear();
                    BoardInfo.PrintBoard(gameBoard);
                    Console.Write("O Wins!\n\n");
                    break;
                }
            }
            

        }
    }
}
