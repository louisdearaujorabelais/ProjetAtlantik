namespace Atlantik_Projet_
{
    partial class FormAjoutLiaison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxListeSecteur = new System.Windows.Forms.ListBox();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbArrivee = new System.Windows.Forms.ComboBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivée = new System.Windows.Forms.Label();
            this.tbxEntreeDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnAjouterLiaison = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxListeSecteur
            // 
            this.lbxListeSecteur.FormattingEnabled = true;
            this.lbxListeSecteur.Location = new System.Drawing.Point(45, 114);
            this.lbxListeSecteur.Name = "lbxListeSecteur";
            this.lbxListeSecteur.Size = new System.Drawing.Size(120, 95);
            this.lbxListeSecteur.TabIndex = 0;
            this.lbxListeSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxListeSecteur_SelectedIndexChanged);
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(297, 114);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbDepart.TabIndex = 1;
            // 
            // cmbArrivee
            // 
            this.cmbArrivee.FormattingEnabled = true;
            this.cmbArrivee.Location = new System.Drawing.Point(549, 114);
            this.cmbArrivee.Name = "cmbArrivee";
            this.cmbArrivee.Size = new System.Drawing.Size(121, 21);
            this.cmbArrivee.TabIndex = 2;
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(42, 98);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblSecteur.TabIndex = 3;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(246, 117);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(45, 13);
            this.lblDepart.TabIndex = 4;
            this.lblDepart.Text = "Départ :";
            // 
            // lblArrivée
            // 
            this.lblArrivée.AutoSize = true;
            this.lblArrivée.Location = new System.Drawing.Point(497, 117);
            this.lblArrivée.Name = "lblArrivée";
            this.lblArrivée.Size = new System.Drawing.Size(46, 13);
            this.lblArrivée.TabIndex = 5;
            this.lblArrivée.Text = "Arrivée :";
            // 
            // tbxEntreeDistance
            // 
            this.tbxEntreeDistance.Location = new System.Drawing.Point(561, 283);
            this.tbxEntreeDistance.Name = "tbxEntreeDistance";
            this.tbxEntreeDistance.Size = new System.Drawing.Size(100, 20);
            this.tbxEntreeDistance.TabIndex = 6;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(497, 286);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 13);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "Distance :";
            // 
            // btnAjouterLiaison
            // 
            this.btnAjouterLiaison.Location = new System.Drawing.Point(573, 333);
            this.btnAjouterLiaison.Name = "btnAjouterLiaison";
            this.btnAjouterLiaison.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterLiaison.TabIndex = 8;
            this.btnAjouterLiaison.Text = "Ajouter";
            this.btnAjouterLiaison.UseVisualStyleBackColor = true;
            this.btnAjouterLiaison.Click += new System.EventHandler(this.btnAjouterLiaison_Click);
            // 
            // FormAjoutLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouterLiaison);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.tbxEntreeDistance);
            this.Controls.Add(this.lblArrivée);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.cmbArrivee);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.lbxListeSecteur);
            this.Name = "FormAjoutLiaison";
            this.Text = "FormAjoutLiaison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxListeSecteur;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbArrivee;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivée;
        private System.Windows.Forms.TextBox tbxEntreeDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnAjouterLiaison;
    }
}