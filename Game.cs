using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Game
    {
        static int Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard();

            BoardViewer viewer = new BoardViewer();
            viewer.Show(chessBoard.Board);

            Console.ReadLine();
            return 0;
        }
    }
}