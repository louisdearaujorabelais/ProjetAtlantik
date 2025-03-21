using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Projet_
{
    internal class Port
    {
        private int NoPort;
        private string Nom;

        public Port(string NouvNom, int nouvNoPort)
        {
            this.NoPort = nouvNoPort;
            this.Nom = NouvNom; 
        }

        public int GetNoPort()
        {
            return NoPort;
        }

        public string GetNom()
        {
            return Nom;
        }

        public override string ToString()
        {
            return Nom;
        }

    }
}
