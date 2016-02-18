using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class BoardViewer
    {
        String pattern = "[a-h][1-8]-[a-h][1-8]";

        public void Show(BoardSquare[,] board)
        {
            for (int j = 7; j >= 0; j--)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (board[i, j].Piece != null)
                    {
                        Console.Write("[ " + board[i, j].Piece.Name + " ]");
                    }
                    else
                    {
                        Console.Write("[   ]");
                    }
                }
                Console.WriteLine();
            }
        }
        public Move getMoveInput()
        {
            String moveInput = Console.ReadLine();
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(moveInput, pattern))
            {
                Console.WriteLine("Input was invalid, please try again");
                return getMoveInput();
            }
            return convertMove(moveInput);
            
        }
        private Move convertMove(String moveInput)
        {
            int x1 = moveInput[0] - 97;
            int y1 = (int) char.GetNumericValue(moveInput[1]) - 1;
                       

            int x2 = moveInput[3] - 97;
            int y2 = (int)char.GetNumericValue(moveInput[4]) - 1;

            return new Move(x1, y1, x2, y2);
        }
    }    
}