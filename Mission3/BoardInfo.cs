using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public static class BoardInfo
    {
        /// <summary>
        /// Enum for game state. NoWinner, X, O, Cat.
        /// </summary>
        public enum GameState
        {
            NoWinner,
            X,
            O,
            Cat
        }
        
        /// <summary>
        /// Prints the game board given a jagged array of char[][]
        /// </summary>
        /// <param name="gameBoard"></param>
        public static void PrintBoard(char[][] gameBoard)
        {
            Console.WriteLine("Game Board\n");

            bool firstRow = true;
            foreach (var line in gameBoard)
            {
                if (!firstRow)
                {
                    Console.WriteLine("\n------------");
                }
                else
                {
                    firstRow = false;
                }
                bool firstInLine = true;
                foreach (var entry in line)
                {
                    if (firstInLine)
                    {
                        Console.Write(entry);
                        firstInLine = false;
                    }
                    else
                    {
                        Console.Write(" | ");
                        Console.Write(entry);
                    }
                }
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Call this method to check for a winner or a cat's game
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns></returns>
        public static GameState CheckWin(char[][] gameBoard)
        {
            GameState state = GameState.NoWinner;
            int length = gameBoard[0].Length;

            //Check lines across
            state = CheckRows(gameBoard, state);

            //Check vertical lines
            state = CheckColumns(gameBoard, state);

            //Check diagonals
            state = CheckDiagonals(gameBoard, state);

            //Check for cat's game only if there is no winner
            if (state == GameState.NoWinner)
            {
                state = CheckCatsGame(gameBoard, state);
            }

            return state;
        }

        /// <summary>
        /// Check rows for equality. Requires a gameboard and state.
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        private static GameState CheckRows(char[][] gameBoard, GameState state)
        {
            foreach (var line in gameBoard)
            {
                char firstItem = line[0];
                bool lineEqual = line
                    .Skip(1)
                    .All(s => s.Equals(firstItem));

                //If equal, determine winner
                if (lineEqual)
                {
                    state = DetermineWinner(firstItem);
                    break;
                }
            }

            return state;
        }

        /// <summary>
        /// Checks columns for equality. Requires a gameboard and state.
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        private static GameState CheckColumns(char[][] gameBoard, GameState state)
        {
            int length = gameBoard[0].Length;

            for (int i = 0; i < length; i++)
            {
                //Vertical array
                char[] vertical = new char[length];

                //Add to array
                for (int j = 0; j < length; j++)
                {
                    vertical[j] = gameBoard[j][i];
                }

                //Check equality
                char firstItem = vertical[0];
                bool colEqual = vertical
                    .Skip(1)
                    .All(s => s.Equals(firstItem));

                if (colEqual)
                {
                    state = DetermineWinner(firstItem);
                    break;
                }
            }

            return state;
        }

        /// <summary>
        /// Checks diagonals for equality. Requires a gameboard and state.
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        private static GameState CheckDiagonals(char[][] gameBoard, GameState state)
        {
            int length = gameBoard[0].Length;

            char[] diagonal1 = new char[length];
            char[] diagonal2 = new char[length];

            //Get diagonals
            for (int i = 0; i < length; i++)
            {
                diagonal1[i] = gameBoard[i][i];
                diagonal2[i] = gameBoard[length - 1 - i][length - 1 - i];
            }

            //Check diagonal 1
            char dChar1 = diagonal1[0];
            bool diagOneEqual = diagonal1
                .Skip(1)
                .All(s => s.Equals(dChar1));

            //Check diagonal 2
            char dChar2 = diagonal2[0];
            bool diagTwoEqual = diagonal2
                .Skip(1)
                .All(s => s.Equals(dChar2));

            //Check for diagonal winners
            if (diagOneEqual)
            {
                state = DetermineWinner(dChar1);
            }
            if (diagTwoEqual)
            {
                state = DetermineWinner(dChar2);
            }

            return state;
        }

        /// <summary>
        /// Checks for a full board with no winner. Requires a gameboard and state.
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        private static GameState CheckCatsGame(char[][] gameBoard, GameState state)
        {
            char[] playerArray = { 'X', 'O' };
            bool ContainsNumbers = false;

            foreach (var line in gameBoard)
            {
                if (line.Any(x => Char.IsDigit(x)))
                {
                    ContainsNumbers = true;
                }
            }

            if (!ContainsNumbers)
            {
                state = GameState.Cat;
            }

            return state;
        }

        /// <summary>
        /// Checks if line is equal. Currently incomplete. Probably won't finish.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static bool IsLineEqual(char[] row)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines which enum value to return based on char input.
        /// </summary>
        /// <param name="winner"></param>
        /// <returns></returns>
        private static GameState DetermineWinner(char winner)
        {
            switch(winner)
            {
                case 'X': return GameState.X;
                case 'O': return GameState.O;
                default: return GameState.NoWinner;
            }
        }
    }
}
