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
            
            MySqlDataReader jeu2Enr = null;
            try
            {
                string requête;
                maCnx.Open(); // on se connecte
                // DEBUT requête paramétrée
                requête = "Select NOPERIODE, DATEDEBUT, DATEFIN from periode";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                jeu2Enr = maCde.ExecuteReader();
                while (jeu2Enr.Read())
                {
                    string EntreeDateDebut = Convert.ToString(jeu2Enr["DATEDEBUT"]);
                    string EntreeDateFin = Convert.ToString(jeu2Enr["DATEFIN"]);
                    int EntreeNoPeriode = Convert.ToInt32(jeu2Enr["NOPERIODE"]);
                    Periode unePeriode = new Periode(EntreeNoPeriode, EntreeDateDebut, EntreeDateFin);
                    cmbPeriode.Items.Add(unePeriode);
                }
            }
            catch (MySqlException u)
            {
                MessageBox.Show("Erreur " + u.ToString());
            }
            finally
            {
                if (jeu2Enr is object & !jeu2Enr.IsClosed)
                {
                    jeu2Enr.Close(); // s'il existe et n'est pas déjà fermé
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

            MySqlDataReader jeu3Enr = null;
            try
            {
                int i = 0;
                string requête;
                maCnx.Open(); // on se connecte
                // DEBUT requête paramétrée
                requête = "Select * from type";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                jeu3Enr = maCde.ExecuteReader();
                while (jeu3Enr.Read())
                {
                    i += 1;
                    string EntreeLettreCategorie = Convert.ToString(jeu3Enr["LETTRECATEGORIE"]);
                    string EntreeLibelle = Convert.ToString(jeu3Enr["LIBELLE"]);
                    int EntreeNoType = Convert.ToInt32(jeu3Enr["NOTYPE"]);
                    Type unType = new Type(EntreeNoType, EntreeLettreCategorie, EntreeLibelle);
                    Label lbl = new Label();
                    lbl.Text = unType.ToString();
                    lbl.Location = new Point(10, i * 30);
                    gbxTarif.Controls.Add(lbl);

                    TextBox tbx = new TextBox();
                    tbx.Location = new Point(120, i * 30);
                    gbxTarif.Controls.Add(tbx);
                  
                }
            }
            catch (MySqlException u)
            {
                MessageBox.Show("Erreur " + u.ToString());
            }
            finally
            {
                if (jeu3Enr is object & !jeu3Enr.IsClosed)
                {
                    jeu3Enr.Close(); // s'il existe et n'est pas déjà fermé
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
                cmbLiaison.Items.Clear();
                string requête;
                maCnx.Open(); // on se connecte
                // DEBUT requête paramétrée
                requête = "SELECT NOLIAISON, PortDepart.nom as 'Nom Port Depart', PortArrivee.nom as 'Nom Port Arrivee' from liaison inner join Port as PortDepart on PortDepart.NoPort = NoPort_Depart inner join port as PortArrivee on (PortArrivee.NoPort = NoPort_Arrivee) where NOSECTEUR = @NOSECTEUR";
                var maCde = new MySqlCommand(requête, maCnx);
                int NoDepart = ((Secteur)(lbxSecteur.SelectedItem)).GetNoSecteur();
                maCde.Parameters.AddWithValue("@NOSECTEUR",NoDepart);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    int EntreeNoLiaison = Convert.ToInt32(jeuEnr["NOLIAISON"]);
                    string EntreeNoMPortDepart = Convert.ToString(jeuEnr["Nom Port Depart"]);
                    string EntreeNoMPortArrivee = Convert.ToString(jeuEnr["Nom Port Arrivee"]);
                    Liaison uneLiaison = new Liaison(EntreeNoLiaison,EntreeNoMPortDepart, EntreeNoMPortArrivee);
                    cmbLiaison.Items.Add(uneLiaison);
                    //((Liaison)(lbxSecteur.SelectedItem)).GetNoPortDepart().ToString();


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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MySqlDataReader jeu3Enr = null;
            try
            {
                int i = 0;
                string requête;
                maCnx.Open(); // on se connecte
                // DEBUT requête paramétrée
                requête = "Select * from type";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                jeu3Enr = maCde.ExecuteReader();
                while (jeu3Enr.Read())
                {
                    i += 1;
                    string EntreeLettreCategorie = Convert.ToString(jeu3Enr["LETTRECATEGORIE"]);
                    string EntreeLibelle = Convert.ToString(jeu3Enr["LIBELLE"]);
                    int EntreeNoType = Convert.ToInt32(jeu3Enr["NOTYPE"]);
                    Type unType = new Type(EntreeNoType, EntreeLettreCategorie, EntreeLibelle);
                    Label lbl = new Label();
                    lbl.Text = unType.ToString();
                    lbl.Location = new Point(10, i * 30);
                    gbxTarif.Controls.Add(lbl);

                    TextBox tbx = new TextBox();
                    tbx.Location = new Point(120, i * 30);
                    gbxTarif.Controls.Add(tbx);

                }
            }
            catch (MySqlException u)
            {
                MessageBox.Show("Erreur " + u.ToString());
            }
            finally
            {
                if (jeu3Enr is object & !jeu3Enr.IsClosed)
                {
                    jeu3Enr.Close(); // s'il existe et n'est pas déjà fermé
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

        }

        private void cmbLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbxTarif_Enter(object sender, EventArgs e)
        {

        }


    }
}
