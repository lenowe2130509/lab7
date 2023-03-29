using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNameSpace
{
    internal class Chat
    {
        private string nom;
        public Chat(string nom) { this.nom = nom; }
        public override string ToString()

        {
            return $"{nom}".ToString();
        }
    }
}
