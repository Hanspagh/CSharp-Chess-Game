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

    }
}
