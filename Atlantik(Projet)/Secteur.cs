using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_Projet_
{
    internal class Secteur

    {
        private int NoSecteur;
        private string Nom ;
        public Secteur(string Nom, int NoSecteur) 
        {
            this.Nom = Nom; 
            this.NoSecteur = NoSecteur; 
        }
        public string GetNom()
        {
            return Nom;
        }
        public override string ToString()
        {
            return Nom;
            // Ce qui apparaitra dans la liste
        }
    }
}
