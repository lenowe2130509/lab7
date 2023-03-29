using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatNameSpace;
using ChienNameSpace;

namespace AmitieNameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Chien chien1 = new Chien("Dog");
            Chien chien2 = new Chien("Doggy");
            Chat chat = new Chat("Cat");


            int humeur = random.Next(0, 2);

            Console.WriteLine($"{chat}, {chien1} et {chien2} se recontrent !");
            if (humeur == 1)
                Console.WriteLine($"{chat} est partie !");
            else
                Console.WriteLine($"{chien1} devient l'ami de {chat} \n" +
                    $"{chat} devient l'ami de {chien1} \n" +
                    $"{chien2} n'a pas d'ami et essai, sans succès de devenir le meilleur ami de {chat}. Pas de chance... {chien1} est attristé et change de meilleur ami, " +
                    $"c'est maintenant {chien2} son nouveau meilleur ami.");
            Console.ReadKey();
        }
    }
}
