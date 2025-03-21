﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
            
        }
        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                maCnx.Open();
                string RequeteAjoutLiaison = "INSERT INTO liaison (NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) VALUES (@NoPortDepart, @NoSecteur, @NoPortArrivee, @Distance)";
                var maCde = new MySqlCommand(RequeteAjoutLiaison, maCnx);
                
                int NoSecteur = ((Secteur)(lbxListeSecteur.SelectedItem)).GetNoSecteur();
                int NoPortDepart = ((Port)(cmbDepart.SelectedItem)).GetNoPort();
                int NoPortArrivee = ((Port)(cmbArrivee.SelectedItem)).GetNoPort();
                double Distance = Convert.ToDouble(tbxEntreeDistance.Text);

                maCde.Parameters.AddWithValue("@NoPortDepart", NoPortDepart);
                maCde.Parameters.AddWithValue("@NoSecteur", NoSecteur);
                maCde.Parameters.AddWithValue("@NoPortArrivee", NoPortArrivee);
                maCde.Parameters.AddWithValue("@Distance", Distance);

                maCde.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                maCnx.Close();
                MessageBox.Show("Ajout Liaison Ok");
            }



        }
        private void FormAjoutLiaison_Load(object sender, EventArgs e)
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
                    lbxListeSecteur.Items.Add(unSecteur);
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


            //mise en place départ
            try
            {
                string requête;
                maCnx.Open(); // on se connecte
                // DEBUT requête paramétrée
                requête = "Select NOPORT, NOM from port";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    string EntreeNom = Convert.ToString(jeuEnr["NOM"]);
                    int EntreeNoPort = Convert.ToInt32(jeuEnr["NOPORT"]);
                    Port unPort = new Port(EntreeNom, EntreeNoPort);
                    cmbDepart.Items.Add(unPort);
                    cmbArrivee.Items.Add(unPort);
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
