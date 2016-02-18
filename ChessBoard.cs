using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class ChessBoard
    {
        public BoardSquare[,] Board = new BoardSquare[8, 8];

        public ChessBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Board[i, j] = new BoardSquare("BLACK");
                    }
                    else
                    {
                        Board[i, j] = new BoardSquare("WHITE");
                    }
                }
            }
            PlacePieces();
        }

        private void PlacePieces()
        {
            for (int i = 0; i < 8; i++)
            {
                Board[i, 1].Piece = new Pawn("WHITE");
                Board[i, 6].Piece = new Pawn("BLACK");
            }
            Board[0, 0].Piece = new Rook("WHITE");
            Board[1, 0].Piece = new Knight("WHITE");
            Board[2, 0].Piece = new Bishop("WHITE");
            Board[3, 0].Piece = new Queen("WHITE");
            Board[4, 0].Piece = new King("WHITE");
            Board[5, 0].Piece = new Bishop("WHITE");
            Board[6, 0].Piece = new Knight("WHITE");
            Board[7, 0].Piece = new Rook("WHITE");

            Board[0, 7].Piece = new Rook("BLACK");
            Board[1, 7].Piece = new Knight("BLACK");
            Board[2, 7].Piece = new Bishop("BLACK");
            Board[3, 7].Piece = new Queen("BLACK");
            Board[4, 7].Piece = new King("BLACK");
            Board[5, 7].Piece = new Bishop("BLACK");
            Board[6, 7].Piece = new Knight("BLACK");
            Board[7, 7].Piece = new Rook("BLACK");
        }
        public BoardSquare getSquare(Tuple<int,int> position)
        {
            return Board[position.Item1, position.Item2];
        }


    }
}