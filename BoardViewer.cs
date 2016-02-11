using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class BoardViewer
    {
    public void Show (BoardSquare[,] Board)
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 7; i >= 0; i--)
                {
                    if (Board[i, j].Piece != null)
                    {
                        Console.Write("[ " + Board[i, j].Piece.Name + " ]");
                    }
                    else
                    {
                        Console.Write("[  ]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
