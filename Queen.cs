using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Queen : Piece
    {

        public Queen(String colour) : base(colour)
        {
            Name = "Q";
        }
    }
}
