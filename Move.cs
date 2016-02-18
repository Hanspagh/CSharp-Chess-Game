using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Move
    {
        public Tuple<int, int> from;

        public Tuple<int, int> to; 

        public Move(int x1,int y1,int x2,int y2)
        {
            from = new Tuple<int, int>(x1, y1);

            to = new Tuple<int, int>(x2, y2);
        }


    }
}
