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
    public partial class FormAjouterTarif : Form
    {
        public FormAjouterTarif()
        {
            InitializeComponent();
        }

        private void FormAjouterTarif_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            //mise en place listbox
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
                    Secteur unSecteur = new Secteur(EntreeNom, EntreeNoSecteur);
                    lbxSecteur.Items.Add(unSecteur);
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

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                string requête;
                maCnx.Open(); // on se connecte
                // DEBUT requête paramétrée
                requête = "select Nom, NOSECTEUR\r\nfrom port \r\ninner join liaison l on (p.noport= l.NOPORT_DEPART)\r\ninner join liaison l on (p.noport= l.NOPORT_ARRIVEE)\r\nwhere NOSECTEUR = 3";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
         
                    cmbLiaison.Items.Add(uneLiaison);
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
    }
}
