using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Vitesse : Piece
    {
        private int roues;
        private int ailes;
        private int chenilles;
        private int vitesse;

        public Vitesse(int vitesse)
        {
            this.vitesse = vitesse;
        }

        public Vitesse(int roues, int ailes, int chenilles)
        {
            this.roues = roues;
            this.ailes = ailes;
            this.chenilles = chenilles;
        }

        public override string ToString()
        {
            nom = $"Vitesse !";
            nom += base.ToString();
            if (roues != 0)
                nom += $"roues qui a une efficacité de Vitesse de : {vitesse}/10 \n";
            else if (ailes != 0)
                nom += $"Marteau qui a une efficacité de Vitesse de : {vitesse}/10 \n";
            else
                nom += $"chenilles qui a une efficacité de Vitesse de : {vitesse}/10 \n";
            nom += "pour la Vitesse du batîment.";

            return nom;
        }
    }
}
