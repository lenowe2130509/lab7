using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{

    internal class Robot
    {
        Piece piece = new Piece();
        
        public Robot(Destruction destruction)
        {
            piece = destruction;
        }

        public Robot(Construction construction)
        {
            piece = construction;
        }

        public Robot(Vitesse vitesse )
        {
            piece = vitesse;
        }

        public Robot(Transport transport)
        {
            piece = transport;
        }

        public override string ToString()
        {
            string robot = "";
            robot += $"Ce robot est de type : " + piece.ToString();
            return robot;
        }
    }
}
