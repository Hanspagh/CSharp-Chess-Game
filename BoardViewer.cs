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
            for (int j = 7; j >= 0; j--)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (Board[i, j].Piece != null)
                    {
                        Console.Write("[ " + Board[i, j].Piece.Name + " ]");
                    }
                    else
                    {
                        Console.Write("[ " + Board[i,j].GetShortName() + " ]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
