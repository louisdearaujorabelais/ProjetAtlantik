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
            
        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {

        }
    }
}
