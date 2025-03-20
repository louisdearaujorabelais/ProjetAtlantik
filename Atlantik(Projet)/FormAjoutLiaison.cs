using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_Projet_
{
    public partial class FormAjoutLiaison : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        public FormAjoutLiaison()
        {
            InitializeComponent();
        }
        private void lbxListeSecteur_SelectedIndexChanged(object sender, EventArgs e)
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
                    string EntreeNom = Convert.ToString(jeuEnr["NOM"]);
                    int EntreeNoSecteur = Convert.ToInt32(jeuEnr["NOSECTEUR"]);
                    Secteur Secteur = new Secteur(EntreeNom, EntreeNoSecteur);
                    lbxListeSecteur.Items.Add(Secteur.GetNom());
                }
            }
            catch (MySqlException u)
            {
                MessageBox.Show("Erreur " + u.ToString());
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
        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {

        }
    }
}
