﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jeux jeux = new Jeux();
            jeux.LancerJeu();
            jeux.ToString();
            Console.ReadKey();
        }
    }
}
