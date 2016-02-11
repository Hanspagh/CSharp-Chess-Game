using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    abstract class Piece
    {
        public String Colour;

        public String Name;

        public Piece(String colour)
        {
            this.Colour = colour;
        }

    }
}
