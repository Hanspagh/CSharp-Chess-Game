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
            throw new NotImplementedException();
        }
    }
}