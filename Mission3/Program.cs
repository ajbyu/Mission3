using System;
using static Mission3.BoardInfo;

namespace Mission3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Section 4 group 12
            //Andrew James, Nathan Bain, Parker George

            Console.WriteLine("Welcome to Tic Tac Toe!"); // Welcome user

            char[][] gameBoard = new char[3][]; // Create game board

            gameBoard[0] = new char[] { '1', '2', '3' };
            gameBoard[1] = new char[] { '4', '5', '6' };
            gameBoard[2] = new char[] { '7', '8', '9' };

            var state = BoardInfo.CheckWin(gameBoard);

            // If there is no winner continue the game
            while (state == GameState.NoWinner)
            {
                bool validInput = false;
                while (validInput == false)
                {
                    //User X inputs
                    Console.Clear();
                    BoardInfo.PrintBoard(gameBoard);
                    Console.WriteLine("Please enter the number to place the 'X': ");
                    string input = Console.ReadLine();
                    char newInput = char.Parse(input);

                    // Adds the user's x to the game board and 
                    for (int i = 0; i < gameBoard.Length; i++)
                    {
                        for (int j = 0; j < gameBoard[i].Length; j++)
                        {
                            // Check if input is valid
                            if (gameBoard[i][j] == newInput)
                            {
                                validInput = true;
                                gameBoard[i][j] = 'X';
                                break;
                            }
                            //If input is not valid, prompt user again
                            else if (i == gameBoard.Length & j == gameBoard.Length & validInput == false)
                            {
                                Console.WriteLine("Please enter a valid input");
                            }
                        }
                    }
                }

                // Allos the O user to add their input to the game
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

                // If X wins it displays that they won
                state = BoardInfo.CheckWin(gameBoard);
                if (state == GameState.X)
                {
                    Console.Clear();
                    BoardInfo.PrintBoard(gameBoard);
                    Console.Write("X Wins!\n\n");
                    break;
                }
                // If Y wins it displays that they won
                else if (state == GameState.O)
                {
                    Console.Clear();
                    BoardInfo.PrintBoard(gameBoard);
                    Console.Write("O Wins!\n\n");
                    break;
                }
                // If no one wins it displays that it was a cat's game
                else if (state == GameState.Cat)
                {
                    Console.Clear();
                    BoardInfo.PrintBoard(gameBoard);
                    Console.Write("Cat's game! No one wins!\n\n");
                    break;
                }
            }
            

        }
    }
}
