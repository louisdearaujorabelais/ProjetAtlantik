using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAtlantik
{
    public partial class PageAccueil : Form
    {
        private Button btnAjouter;
        public PageAccueil()
        {
            InitializeComponent();
            SuspendLayout();
            Text = "Une première fenêtre";    // Le titre de la fenêtre
            Size = new Size(200, 150);        // La taille initiale
            MinimumSize = new Size(200, 150); // La taille minimale

            // Le bouton "Ajouter"
            btnAjouter = new Button();
            btnAjouter.Text = "Fermer";
            btnAjouter.AutoSize = true;             // Taille selon le contenu
            btnAjouter.Location = new Point(50, 60);// Position x=50 y=60
            btnAjouter.Click += new System.EventHandler(btnAjouter_Click);  /* Si Click sur « btnAjouter » on appelle la méthode « btnAjouter_Click ») */
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Secteur Ajouter");
            Application.Exit();
        }
        public void buttonTest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
