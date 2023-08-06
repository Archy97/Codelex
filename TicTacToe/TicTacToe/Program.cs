using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] _board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            var counter = 0;

            while (HasAnEmptyCell())
            {
                var player = counter % 2 == 0 ? 'x' : 'o';
                Console.WriteLine("Ievadi kooardinātes formātā X Y. ");
                var input = Console.ReadLine();
                var coords = input.Split(' ');
                var x = int.Parse(coords[0]);
                var y = int.Parse(coords[1]);
                if (_board[x, y] == ' ')
                {
                    _board[x, y] = player;
                    counter++;
                }

                DisplayBoard();
                if (!HasAnEmptyCell())
                {
                    Console.WriteLine("It's a tie!");
                }
                if (HasWinner())
                {
                    Console.WriteLine("Winner is " + player);
                }
            }
        }

        private static bool HasWinner()
        {
            char[] players = { 'x', 'o' };

            foreach (char player in players)
            {
                if ((_board[0, 0] == player && _board[0, 1] == player && _board[0, 2] == player) ||
                    (_board[1, 0] == player && _board[1, 1] == player && _board[1, 2] == player) ||
                    (_board[2, 0] == player && _board[2, 1] == player && _board[2, 2] == player) ||
                    (_board[0, 0] == player && _board[1, 0] == player && _board[2, 0] == player) ||
                    (_board[0, 1] == player && _board[1, 1] == player && _board[2, 1] == player) ||
                    (_board[0, 2] == player && _board[1, 2] == player && _board[2, 2] == player) ||
                    (_board[0, 0] == player && _board[1, 1] == player && _board[2, 2] == player) ||
                    (_board[0, 2] == player && _board[1, 1] == player && _board[2, 0] == player))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool HasAnEmptyCell()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    if (_board[r, c] == ' ')
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    _board[r, c] = ' ';
                }
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + _board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + _board[2, 0] + "|" + _board[2, 1] + "|" + _board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}