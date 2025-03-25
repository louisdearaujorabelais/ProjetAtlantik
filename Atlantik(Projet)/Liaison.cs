using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_Projet_
{
    internal class Liaison
    {
        private int NoLiaison;
        private string NomPortDepart;
        private string NomPortArrivee;
        
        public Liaison(int NoLiaison, string NomPortDepart, string NomPortArrivee) 
        {
            this.NoLiaison = NoLiaison;
            this.NomPortDepart = NomPortDepart;
            this.NomPortArrivee = NomPortArrivee;    
        }

        public int GetNoLiaison()
        {
            return NoLiaison;
        }

        public string GetNoPortDepart()
        { 
            return NomPortDepart; 
        }

        public string GetNoPortArrivee()
        {
            return NomPortArrivee;
        }

        public override string ToString()
        {
            return NomPortDepart + " - " + NomPortArrivee;
        }
    }
}
