namespace Atlantik_Projet_
{
    partial class FormAjouterTarif
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
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.cmbPeriode = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gbxTarif = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(85, 35);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 95);
            this.lbxSecteur.TabIndex = 0;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(82, 19);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblSecteur.TabIndex = 1;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(82, 259);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(85, 275);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 3;
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(127, 378);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(49, 13);
            this.lblPeriode.TabIndex = 4;
            this.lblPeriode.Text = "Période :";
            // 
            // cmbPeriode
            // 
            this.cmbPeriode.FormattingEnabled = true;
            this.cmbPeriode.Location = new System.Drawing.Point(182, 375);
            this.cmbPeriode.Name = "cmbPeriode";
            this.cmbPeriode.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriode.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(506, 368);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // gbxTarif
            // 
            this.gbxTarif.Location = new System.Drawing.Point(315, 19);
            this.gbxTarif.Name = "gbxTarif";
            this.gbxTarif.Size = new System.Drawing.Size(266, 292);
            this.gbxTarif.TabIndex = 7;
            this.gbxTarif.TabStop = false;
            this.gbxTarif.Text = "Tarifs par Catégorie-Type";
            // 
            // FormAjouterTarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.gbxTarif);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbPeriode);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAjouterTarif";
            this.Load += new System.EventHandler(this.FormAjouterTarif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.ComboBox cmbPeriode;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox gbxTarif;
    }
}