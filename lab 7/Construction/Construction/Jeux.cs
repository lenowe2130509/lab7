using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Jeux
    {
        Usine usine = new Usine();
        Ville ville = new Ville();
        private int oui;
        public Jeux ()
        {

        }

        public bool LancerJeu()
        {
            bool isGameOver = false;
            int compteur =0;
            oui = 0;
            while(!isGameOver)
            {
                if (ville.Batiments[compteur].Etat == qualite.parfait)
                {
                    Console.WriteLine($"Le batiment {compteur} est dans un parfait état ! Passez au prochain !");
                    compteur++;
                    oui++;
                }
                else if(ville.Batiments[compteur].Etat == qualite.a_construire)
                {
                    Console.WriteLine($"Le batiment {compteur} est dans un mauvais état et doit être reconstruit !");
                    Console.WriteLine($"Le robot envoyé est un robot de : \n");
                    usine.CreeRobot(types.transport);
                    Console.WriteLine($"Il envoie les ressources nécessaire à la réparation qui est faites par :");
                    Console.WriteLine($"le robot envoyé : \n");
                    usine.CreeRobot(types.construction);
                    compteur++;
                    oui++;
                }
                else
                {
                    Console.WriteLine($"Le batiment {compteur} est dans un trop mauvais état et doit être détruit !");
                    Console.WriteLine($"Le robot envoyé est un robot de : \n");
                    usine.CreeRobot(types.destruction);
                    Console.WriteLine($"Mais pour qu'il arrive plus vite on a fait appel à un autre robot : \n");
                    usine.CreeRobot(types.vitesse);
                    compteur++;
                    oui++;
                }
                if (compteur > 4)
                    isGameOver = true;
            }

            return isGameOver;
        }

        public override string ToString()
        {
            string message = "";
            message += $"Le nombre de tour afin de réparer les dégats que la ville a subi est de {oui}\n " +
                $"Les batiments ont subi des changements ! Les batiments qui étaient parfait et le restent ! \n " +
                $"Les batiments qui devaient se faire détruire sont actuellement détruit et ceux devant se faire réparer sont reconstruit ";

            return message;

        }
    }
}
