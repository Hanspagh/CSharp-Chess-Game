using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class BoardSquare
    {
        public String Colour;

        public Piece Piece;

        public BoardSquare(String Colour) {
            this.Colour = Colour;
        }
        public String GetShortName ()
        {
            if (Colour == "BLACK") { return "B"; }
            else if (Colour == "WHITE") { return "W"; }
            else { return "NO COLOUR"; }
        }
    }
}