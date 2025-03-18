namespace Atlantik_Projet_
{
    partial class FormAjoutSecteur
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
            this.btnAjoutSecteur = new System.Windows.Forms.Button();
            this.tbxEntreeSecteur = new System.Windows.Forms.TextBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjoutSecteur
            // 
            this.btnAjoutSecteur.Location = new System.Drawing.Point(361, 244);
            this.btnAjoutSecteur.Name = "btnAjoutSecteur";
            this.btnAjoutSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutSecteur.TabIndex = 0;
            this.btnAjoutSecteur.Text = "Ajouter";
            this.btnAjoutSecteur.UseVisualStyleBackColor = true;
            this.btnAjoutSecteur.Click += new System.EventHandler(this.btnAjoutSecteur_Click);
            // 
            // tbxEntreeSecteur
            // 
            this.tbxEntreeSecteur.Location = new System.Drawing.Point(346, 177);
            this.tbxEntreeSecteur.Name = "tbxEntreeSecteur";
            this.tbxEntreeSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxEntreeSecteur.TabIndex = 1;
            this.tbxEntreeSecteur.TextChanged += new System.EventHandler(this.tbxEntreeSecteur_TextChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(265, 180);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(75, 13);
            this.lblSecteur.TabIndex = 2;
            this.lblSecteur.Text = "Nom Secteur :";
            // 
            // FormAjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.tbxEntreeSecteur);
            this.Controls.Add(this.btnAjoutSecteur);
            this.Name = "FormAjoutSecteur";
            this.Text = "FormAjoutSecteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutSecteur;
        private System.Windows.Forms.TextBox tbxEntreeSecteur;
        private System.Windows.Forms.Label lblSecteur;
    }
}