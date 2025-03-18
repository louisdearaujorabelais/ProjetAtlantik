using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Projet_
{
    internal class Secteur

    {
        private int NoSecteur;
        private string Nom ;
        public Secteur(int NoSecteur, string Nom) 
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                string requête;
                maCnx.Open(); // on se connecte
                // DEBUT requête paramétrée
                requête = "Select NOSECTEUR, NOM from secteur";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Console.Write(jeuEnr["NOSECTEUR"] + "\t");
                    Console.Write(jeuEnr["NOM"] + "\t");
                    Console.WriteLine();
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur " + e.ToString());
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }
        public override string ToString()
        {
            return Nom + " - " + NoSecteur;
            // Ce qui apparaitra dans la liste
        }
    }
}
