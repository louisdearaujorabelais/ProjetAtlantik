﻿namespace Atlantik_Projet_
{
    partial class FormAjoutPort
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
            this.btnAjouterPort = new System.Windows.Forms.Button();
            this.tbxEntreePort = new System.Windows.Forms.TextBox();
            this.lblNomPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouterPort
            // 
            this.btnAjouterPort.Location = new System.Drawing.Point(359, 223);
            this.btnAjouterPort.Name = "btnAjouterPort";
            this.btnAjouterPort.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterPort.TabIndex = 0;
            this.btnAjouterPort.Text = "Ajouter";
            this.btnAjouterPort.UseVisualStyleBackColor = true;
            this.btnAjouterPort.Click += new System.EventHandler(this.btnAjouterPort_Click);
            // 
            // tbxEntreePort
            // 
            this.tbxEntreePort.Location = new System.Drawing.Point(347, 158);
            this.tbxEntreePort.Name = "tbxEntreePort";
            this.tbxEntreePort.Size = new System.Drawing.Size(100, 20);
            this.tbxEntreePort.TabIndex = 1;
            this.tbxEntreePort.TextChanged += new System.EventHandler(this.tbxEntreePort_TextChanged);
            // 
            // lblNomPort
            // 
            this.lblNomPort.AutoSize = true;
            this.lblNomPort.Location = new System.Drawing.Point(285, 158);
            this.lblNomPort.Name = "lblNomPort";
            this.lblNomPort.Size = new System.Drawing.Size(56, 13);
            this.lblNomPort.TabIndex = 2;
            this.lblNomPort.Text = "Nom port :";
            // 
            // FormAjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomPort);
            this.Controls.Add(this.tbxEntreePort);
            this.Controls.Add(this.btnAjouterPort);
            this.Name = "FormAjoutPort";
            this.Text = "FormAjoutPort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterPort;
        private System.Windows.Forms.TextBox tbxEntreePort;
        private System.Windows.Forms.Label lblNomPort;
    }
}