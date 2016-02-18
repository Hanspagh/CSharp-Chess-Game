using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Rook : Piece
    {
        public Rook(String colour) : base(colour)
        {
            Name = "R";

        }

        internal override bool validateMove(Move move, ChessBoard board)
        {
            if ((Math.Abs(move.to.Item1 - move.from.Item1) > 0) ^ (Math.Abs(move.to.Item2 - move.from.Item2) > 0))
            {
                // End position possible
                if (Math.Abs(move.to.Item1 - move.from.Item1) > 0)
                {
                    int numberOfMoves = Math.Abs(move.to.Item1 - move.from.Item1)-1;
                    int movePosition = move.from.Item1;
                    int dir = move.to.Item1 - move.from.Item1 > 0 ? 1: -1;
                    for (int i = 0; i < numberOfMoves; i++)
                    {
                        movePosition += dir;
                        if (board.Board[movePosition, move.from.Item2].Piece != null)
                        {
                            return false;
                        }
                    }
                    return board.getSquare(move.to).Piece == null || board.getSquare(move.to).Piece.Colour != Colour;
                }
                if (Math.Abs(move.to.Item2 - move.from.Item2) > 0)
                {
                    int numberOfMoves = Math.Abs(move.to.Item2 - move.from.Item2)-1;
                    int movePosition = move.from.Item2;
                    int dir = move.to.Item2 - move.from.Item2 > 0 ? 1 : -1;
                    for (int i = 0; i < numberOfMoves; i++)
                    {
                        movePosition += dir;
                        if (board.Board[move.from.Item1,movePosition].Piece != null)
                        {
                            return false;
                        }
                    }

                    return board.getSquare(move.to).Piece == null || board.getSquare(move.to).Piece.Colour != Colour;
                }
            }
            return false;
        }
    }
}