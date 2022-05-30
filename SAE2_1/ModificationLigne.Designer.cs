namespace SAE2_1
{
    partial class ModificationLigne
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
            this.pnl_LigneModif = new System.Windows.Forms.Panel();
            this.cbo_choix_ligne = new System.Windows.Forms.ComboBox();
            this.lblLigne_a_Modifier = new System.Windows.Forms.Label();
            this.lblTitreModifLigne = new System.Windows.Forms.Label();
            this.cmd_Retour = new System.Windows.Forms.Button();
            this.cmd_modifier = new System.Windows.Forms.Button();
            this.pnl_LigneModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_LigneModif
            // 
            this.pnl_LigneModif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_LigneModif.Controls.Add(this.cbo_choix_ligne);
            this.pnl_LigneModif.Controls.Add(this.lblLigne_a_Modifier);
            this.pnl_LigneModif.Location = new System.Drawing.Point(48, 118);
            this.pnl_LigneModif.Name = "pnl_LigneModif";
            this.pnl_LigneModif.Size = new System.Drawing.Size(704, 204);
            this.pnl_LigneModif.TabIndex = 0;
            // 
            // cbo_choix_ligne
            // 
            this.cbo_choix_ligne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_choix_ligne.FormattingEnabled = true;
            this.cbo_choix_ligne.Location = new System.Drawing.Point(261, 117);
            this.cbo_choix_ligne.Name = "cbo_choix_ligne";
            this.cbo_choix_ligne.Size = new System.Drawing.Size(182, 24);
            this.cbo_choix_ligne.TabIndex = 3;
            this.cbo_choix_ligne.SelectionChangeCommitted += new System.EventHandler(this.cbo_choix_ligne_SelectionChangeCommitted);
            // 
            // lblLigne_a_Modifier
            // 
            this.lblLigne_a_Modifier.AutoSize = true;
            this.lblLigne_a_Modifier.BackColor = System.Drawing.Color.Transparent;
            this.lblLigne_a_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigne_a_Modifier.Location = new System.Drawing.Point(236, 50);
            this.lblLigne_a_Modifier.Name = "lblLigne_a_Modifier";
            this.lblLigne_a_Modifier.Size = new System.Drawing.Size(232, 32);
            this.lblLigne_a_Modifier.TabIndex = 2;
            this.lblLigne_a_Modifier.Text = "Ligne à modifier :";
            // 
            // lblTitreModifLigne
            // 
            this.lblTitreModifLigne.AutoSize = true;
            this.lblTitreModifLigne.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreModifLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreModifLigne.Location = new System.Drawing.Point(169, 22);
            this.lblTitreModifLigne.Name = "lblTitreModifLigne";
            this.lblTitreModifLigne.Size = new System.Drawing.Size(462, 54);
            this.lblTitreModifLigne.TabIndex = 1;
            this.lblTitreModifLigne.Text = "Modification de Ligne";
            // 
            // cmd_Retour
            // 
            this.cmd_Retour.BackColor = System.Drawing.Color.Gray;
            this.cmd_Retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_Retour.ForeColor = System.Drawing.Color.White;
            this.cmd_Retour.Location = new System.Drawing.Point(48, 355);
            this.cmd_Retour.Name = "cmd_Retour";
            this.cmd_Retour.Size = new System.Drawing.Size(120, 66);
            this.cmd_Retour.TabIndex = 2;
            this.cmd_Retour.Text = "Retour";
            this.cmd_Retour.UseVisualStyleBackColor = false;
            // 
            // cmd_modifier
            // 
            this.cmd_modifier.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd_modifier.Enabled = false;
            this.cmd_modifier.ForeColor = System.Drawing.Color.White;
            this.cmd_modifier.Location = new System.Drawing.Point(632, 355);
            this.cmd_modifier.Name = "cmd_modifier";
            this.cmd_modifier.Size = new System.Drawing.Size(120, 66);
            this.cmd_modifier.TabIndex = 3;
            this.cmd_modifier.Text = "Modifier";
            this.cmd_modifier.UseVisualStyleBackColor = false;
            this.cmd_modifier.Click += new System.EventHandler(this.cmd_modifier_Click);
            // 
            // ModificationLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd_modifier);
            this.Controls.Add(this.cmd_Retour);
            this.Controls.Add(this.lblTitreModifLigne);
            this.Controls.Add(this.pnl_LigneModif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ModificationLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificationLigne";
            this.Load += new System.EventHandler(this.ModificationLigne_Load);
            this.pnl_LigneModif.ResumeLayout(false);
            this.pnl_LigneModif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_LigneModif;
        private System.Windows.Forms.ComboBox cbo_choix_ligne;
        private System.Windows.Forms.Label lblLigne_a_Modifier;
        private System.Windows.Forms.Label lblTitreModifLigne;
        private System.Windows.Forms.Button cmd_Retour;
        private System.Windows.Forms.Button cmd_modifier;
    }
}