using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienNameSpace
{
    internal class Chien
    {
        private string nom;
        public Chien(string nom){ this.nom = nom; }

        public override string ToString()

        {
            return $"{nom}".ToString();
        }
    }
}
