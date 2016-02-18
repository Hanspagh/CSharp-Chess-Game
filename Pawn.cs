using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Pawn : Piece
    {

        public Pawn(String colour) : base(colour) {
            Name = "P";
        }

        internal override bool validateMove(Move move, ChessBoard board)
        {
            int dir = Colour == "BLACK" ? -1 : 1;

            if (move.to.Item2 - move.from.Item2 == dir)
            {
                //Moving forward
                if (Math.Abs(move.to.Item1 - move.from.Item1) == 0)
                {
                    return (board.getSquare(move.to).Piece == null);
                }
                //Moving sideways
                if (Math.Abs(move.to.Item1 - move.from.Item1) == 1)
                {
                    return (board.getSquare(move.to).Piece != null && board.getSquare(move.to).Piece.Colour != Colour);
                }

                //Cheating
                return false;
            }
            else if (!Moved && move.to.Item2 - move.from.Item2 == 2 * dir)
            {
                return (board.getSquare(move.to).Piece == null);
            }
            else
            {
                return false;
            }
           
        }
    }
}