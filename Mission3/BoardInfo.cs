using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Game Board");
            Console.WriteLine("------------");
            foreach (var line in gameBoard)
            {
                Console.Write("|");
                foreach (var entry in line)
                {
                    Console.Write(entry);
                    Console.Write(" | ");
                }
                Console.WriteLine("\n------------");
            }
        }

        public static GameState CheckWin(char[][] gameBoard)
        {
            GameState state = GameState.NoWinner;

            //Check for 
            foreach (var line in gameBoard)
            {
                char firstItem = line[0];
                bool lineEqual = gameBoard[0]
                    .Skip(1)
                    .All(s => s.Equals(firstItem));

                if (lineEqual)
                {

                }
            }
        }

        private char DetermineWinner(char winner)
        {
            
        }
    }
}
