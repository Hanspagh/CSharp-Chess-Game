using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Knight : Piece
    {
        public Knight(String colour) : base(colour)
        {
            Name = "Kn";
        }

        internal override bool validateMove(Move move, ChessBoard board)
        {
            throw new NotImplementedException();
        }
    }
}