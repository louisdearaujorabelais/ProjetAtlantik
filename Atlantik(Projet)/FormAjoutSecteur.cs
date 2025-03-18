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
    public partial class FormAjoutSecteur : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        public FormAjoutSecteur()
        {
            InitializeComponent();
        }

        private void btnAjoutSecteur_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajout du Secteur : " + tbxEntreeSecteur.Text);
            try
            {
                maCnx.Open();
                string RequeteAjoutPort = "INSERT INTO secteur (NOM) VALUES (@Port)";
                var maCde = new MySqlCommand(RequeteAjoutPort, maCnx);
                string Port = tbxEntreeSecteur.Text;
                maCde.Parameters.AddWithValue("@Port", Port);
                maCde.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                maCnx.Close();
                MessageBox.Show("Ajout Ok");
            }
        }

        private void tbxEntreeSecteur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
