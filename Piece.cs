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

        public bool Moved = false;

        public Piece(String colour)
        {
            this.Colour = colour;
        }

        internal abstract bool validateMove(Move move, ChessBoard board);
    }
}