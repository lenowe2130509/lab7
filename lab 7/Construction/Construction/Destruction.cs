using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Destruction : Piece
    {
        private int buldozer;
        private int marteauPiqueur;
        private int cQuatre;
        private int detruire;

        public Destruction(int detruire)
        {
            this.detruire = detruire;
        }

        public Destruction(int buldozer , int marteauPiqueur , int cQuatre )
        {
            this.buldozer = buldozer;
            this.marteauPiqueur = marteauPiqueur;
            this.cQuatre = cQuatre;
        }

        public override string ToString()
        {
            nom = $"Destruction !";
            nom += base.ToString();
            if (detruire > 7)
                nom += $"C4 qui a une puissance de destruction de : {detruire}/10 \n";
            
            else if (detruire > 3)   
                nom += $"Buldozer qui a une puissance de destruction de : {detruire}/10 \n";
            else
                nom += $"Marteau-piqueur qui a une puissance de destruction de : {detruire}/10 \n";
            nom += "pour la destruction du batîment.";

            return nom;
        }

    }
}
