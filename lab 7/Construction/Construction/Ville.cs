using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{


    internal class Ville
    {
        public Batiment[] Batiments { get; set; }

        public Ville()
        {
            Batiments = new Batiment[5];
            CreeBatiment();
        }

        private void CreeBatiment()
        {
            Batiments[0] = new Batiment(qualite.parfait,5);
            Batiments[1] = new Batiment(qualite.parfait,4);
            Batiments[2] = new Batiment(qualite.a_detruire,1);
            Batiments[3] = new Batiment(qualite.a_detruire,2);
            Batiments[4] = new Batiment(qualite.a_construire,3);
        }
    }
}
