using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class King : Piece
    {

        public King(String colour) : base(colour)
        {
            Name = "K";
        }

        internal override bool validateMove(Move move, ChessBoard board)
        {
            if ( Math.Abs(move.to.Item1-move.from.Item1) <= 1  && Math.Abs(move.to.Item2 - move.from.Item2) <= 1  &&
                ((Math.Abs(move.to.Item1 - move.from.Item1) + Math.Abs(move.to.Item2 - move.from.Item2) > 0)))
            {
                return board.getSquare(move.to).Piece == null || board.getSquare(move.to).Piece.Colour != Colour;
            }
            return false;
        }
    }
}