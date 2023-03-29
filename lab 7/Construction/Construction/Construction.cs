using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Construction : Piece
    {
        private int PISTOLET_DE_CALFEUTRAGE;
        private int Panneaux;
        private int ciment;
        private int construire;

        public Construction(int construire)
        {
            this.construire = construire;
        }

        public Construction(int PISTOLET_DE_CALFEUTRAGE, int Panneaux, int ciment)
        {
            this.PISTOLET_DE_CALFEUTRAGE = PISTOLET_DE_CALFEUTRAGE;
            this.Panneaux = Panneaux;
            this.ciment = ciment;
        }

        public override string ToString()
        {
            nom = $"Construction !";
            nom += base.ToString();
            if (PISTOLET_DE_CALFEUTRAGE > 7)
                nom += $"PISTOLET_DE_CALFEUTRAGE qui a une efficacité de construction de : {construire}/10 \n";
            else if (Panneaux > 3)
                nom += $"Marteau qui a une efficacité de construction de : {construire}/10 \n";
            else
                nom += $"Ciment qui a une efficacité de construction de : {construire}/10 \n";
            nom += "pour la construction du batîment.";

            return nom;
        }
    }
}
