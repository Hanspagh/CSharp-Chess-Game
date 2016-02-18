using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Game
    {
        public ChessBoard chessBoard;
        public BoardViewer viewer;


        public Game()
        {
            chessBoard = new ChessBoard();
            viewer = new BoardViewer();
            while (true)
            {
                viewer.Show(chessBoard.Board);
                makeMove(viewer.getMoveInput());

            }
        }
 
        private void makeMove(Move move)
        {
            Piece piece = chessBoard.getSquare(move.from).Piece;
            if (piece == null || !piece.validateMove(move, chessBoard))
            {
                Console.WriteLine("Invalid move.");
                return;
            }
            chessBoard.getSquare(move.to).Piece = piece;
            piece.Moved = true;
            chessBoard.getSquare(move.from).Piece = null;
            }
    }
}