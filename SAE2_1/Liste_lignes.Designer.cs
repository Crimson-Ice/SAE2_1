﻿namespace SAE2_1
{
    partial class Liste_lignes
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
            this.Gb_Ligne_a_affichager = new System.Windows.Forms.GroupBox();
            this.pnl_btn = new System.Windows.Forms.FlowLayoutPanel();
            this.Gb_Ligne_a_affichager.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Ligne_a_affichager
            // 
            this.Gb_Ligne_a_affichager.Controls.Add(this.pnl_btn);
            this.Gb_Ligne_a_affichager.Location = new System.Drawing.Point(182, 45);
            this.Gb_Ligne_a_affichager.Name = "Gb_Ligne_a_affichager";
            this.Gb_Ligne_a_affichager.Size = new System.Drawing.Size(437, 360);
            this.Gb_Ligne_a_affichager.TabIndex = 2;
            this.Gb_Ligne_a_affichager.TabStop = false;
            this.Gb_Ligne_a_affichager.Text = "Liste des lignes";
            // 
            // pnl_btn
            // 
            this.pnl_btn.AutoScroll = true;
            this.pnl_btn.Location = new System.Drawing.Point(19, 18);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(399, 324);
            this.pnl_btn.TabIndex = 1;
            // 
            // Liste_lignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gb_Ligne_a_affichager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Liste_lignes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des lignes";
            this.Load += new System.EventHandler(this.Liste_lignes_Load);
            this.Gb_Ligne_a_affichager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Ligne_a_affichager;
        private System.Windows.Forms.FlowLayoutPanel pnl_btn;
    }
}