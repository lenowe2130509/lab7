using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Drawing;
using Console = Colorful.Console;

namespace AffichagePasCommeLesAutres
{
    internal class Program
    {

        static void Main(string[] args)
        {

            TestConsole();
            Console.WriteLine(TestHumain());
            Console.WriteLine(TestHumain1());
            Console.WriteLine(TestHumain2());
            Console.WriteLine(TestHumain3());
            Console.WriteLine(TestHumain4());
            Console.ReadKey();
        }

        //Retraduit la date en Humain afin que l'on comprenne
        static string TestHumain()
        {
            string date = "";
            date = DateTime.UtcNow.AddMonths(1).Humanize();
            return date;
        }

        //Met le chiffre en mot
        static int TestHumain1()
        {
            int modification = 1552;
            modification.ToWords();
            return modification;
        }

        //transforme les millisecondes en minutes, heures, semaines, mois, années
        static string TestHumain2()
        {
            string date = "";
            date = TimeSpan.FromMilliseconds(158764).Humanize(5);
            return date;
        }
        
        // met au pluriel les textes
        static string TestHumain3()
        {
            string pluriel = "";

            pluriel = "c'est moi".Pluralize();
            return pluriel;
        }

        //Ajoute le nombre de quantité demandé et mets au pluriel si besoin
        static string TestHumain4()
        {
            string nombre = "";
            nombre = "personne".ToQuantity(10);
            return nombre;
        }

        static void TestConsole() 
        {
            
            List<char> chars = new List<char>()
            {
                'Y', 'O', ' ', 'W', 'H', 'A', 'T', ' ', 's', ' ', 'u', 'p', '!'                
            };
           
            Console.WriteWithGradient(chars, Color.Yellow, Color.Fuchsia, 14);
        }
    }
}
