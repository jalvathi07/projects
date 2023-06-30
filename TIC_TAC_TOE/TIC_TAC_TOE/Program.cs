using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    class Program
    {
        static char state ;
        static string op;
        static string[] board = new string[9];
        static char player;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("                       WELCOME TO THE GAME");
                Console.WriteLine();
                Console.WriteLine("                     T I C    T A C    T O E");
                putvalue();
                Console.WriteLine();
                Console.Write("Player Type[X/O] :");
                player = char.Parse(Console.ReadLine());
                for (int i = 0; i < 9; i++)
                {
                    Console.Clear();
                    Console.WriteLine("                       WELCOME TO THE GAME");
                    Console.WriteLine();
                    Console.WriteLine("                     T I C    T A C    T O E");
                    Display_board(board);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Player:" + player);
                    Console.WriteLine();
                    Console.Write("Position :");
                    int position = int.Parse(Console.ReadLine());
                    Data_input(player, position);
                    player = Flip_player(player);
                    state = Winning_state(board);
                    if (state == 'W')
                    {
                        Console.Clear();
                        Display_board(board);
                        Console.WriteLine();
                        Console.WriteLine();
                        player = Flip_player(player);
                        Console.WriteLine("[ " + player + " ]" + "  WIN");
                        Console.WriteLine();
                        Console.WriteLine("DO YOU WANT PLAY AGAIN [TYPE YES]");
                        op = Console.ReadLine();
                        break;
                    }
                    if (state == 'D' && i == 8)
                    {
                        Console.Clear();
                        Display_board(board);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" MATCH DRAW");
                        break;
                        Console.WriteLine();
                        Console.WriteLine("DO YOU WANT PLAY AGAIN [TYPE YES]");
                        op = Console.ReadLine();
                    }
                    Console.Clear();
                }
            } while (op == "YES");
        }
        #region io
        public static char Winning_state(string[] board)
        {
            state = 'D';
            for (int i = 0; i < 9; i += 3)
            {
               if (board[0]==board[1]&& board[1]==board[2])
                {
                    state='W';
                }
            }
            if (board[0] == board[3] && board[3] == board[6])
            {
                state = 'W';
            }
            if (board[1] == board[4] && board[4] == board[7])
            {
                state = 'W';
            }
            if (board[2] == board[5] && board[5] == board[8])
            {
                state = 'W';
            }
            if (board[0] == board[4] && board[4] == board[8])
            {
                state = 'W';
            }
            if (board[2] == board[4] && board[4] == board[6])
            {
                state = 'W';
            }
            return state;
        }
        public static void Data_input(char player, int pos)
        {
            board[pos] = player.ToString().ToUpper();
        }
        public static char Flip_player(char player)
        {
            if (player == 'X'||player=='x')
            {
                player = 'O';
            }
            else if (player == 'O'||player=='o')
            {
                player ='X';
            }
            return player;
        }
        public static void putvalue()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = i.ToString();
            }
        }
        public static void Display_board(string []ar)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3== 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.Write("|"+ar[i]+"|\t");
            }
        }

    }
        #endregion

}
