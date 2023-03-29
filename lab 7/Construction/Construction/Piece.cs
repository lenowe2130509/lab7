using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Piece
    {
        protected string nom;

        public Piece()
        {

        }

        public override string ToString()
        {
            nom = $" \n Les pièces de ce Robot sont : ";
            return nom;
        }

    }
}
