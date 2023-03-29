using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Transport : Piece
    {
        private int catapulte;
        private int camion;
        private int trains;
        private int transport;

        public Transport(int transport)
        {
            this.transport = transport;
        }

        public Transport(int catapulte, int camion, int trains)
        {
            this.catapulte = catapulte;
            this.camion = camion;
            this.trains = trains;
        }

        public override string ToString()
        {
            nom = $"Transport !";
            nom += base.ToString();
            if (catapulte > 7)
                nom += $"trains qui a une efficacité de Transport de : {transport}/10 \n"; 
            else if (camion > 3)
                nom += $"Marteau qui a une efficacité de Transport de : {transport}/10 \n";
            else
                nom += $"catapulte qui a une efficacité de Transport de : {transport}/10 \n";
            nom += "pour la Transport du batîment.";

            return nom;
        }
    }
}
