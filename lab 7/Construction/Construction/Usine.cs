using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Construction
{
    enum types
    {
        destruction,
        construction,
        transport,
        vitesse
    }

    internal class Usine
    {
        public Usine() 
        {
           
        }

        public void CreeRobot(types monType)
        {
            Random random = new Random();
            Thread.Sleep(10);                    //Met un délai pour le random afin que toutes les valeurs changent !
            Robot robot;
            if (monType == types.destruction)
            {
                robot = new Robot(new Destruction(random.Next(0, 11)));
                Console.WriteLine(robot.ToString());
            }  
            else if (monType == types.construction)
            {
                robot = new Robot(new Construction(random.Next(0, 11)));
                Console.WriteLine(robot.ToString());
            }
            else if (monType == types.vitesse)
            {
                robot = new Robot(new Vitesse(random.Next(0, 11)));
                Console.WriteLine(robot.ToString());
            }
            else
            {
                robot = new Robot(new Transport(random.Next(0, 11)));
                Console.WriteLine(robot.ToString());
            }
        }
    }
}
