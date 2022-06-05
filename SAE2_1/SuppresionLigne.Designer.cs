namespace SAE2_1
{
    partial class SuppresionLigne
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
            this.lblSuppresionLigne = new System.Windows.Forms.Label();
            this.pnl_LigneSupp = new System.Windows.Forms.Panel();
            this.cbo_ligne = new System.Windows.Forms.ComboBox();
            this.lbl_Ligne_a_Supprimer = new System.Windows.Forms.Label();
            this.lbl_Messager_Attention = new System.Windows.Forms.Label();
            this.pic_Attention = new System.Windows.Forms.PictureBox();
            this.cmd_Retour = new System.Windows.Forms.Button();
            this.cmd_Valider = new System.Windows.Forms.Button();
            this.cmd_visualiser = new System.Windows.Forms.Button();
            this.pnl_LigneSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Attention)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuppresionLigne
            // 
            this.lblSuppresionLigne.AutoSize = true;
            this.lblSuppresionLigne.BackColor = System.Drawing.Color.Transparent;
            this.lblSuppresionLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppresionLigne.Location = new System.Drawing.Point(186, 33);
            this.lblSuppresionLigne.Name = "lblSuppresionLigne";
            this.lblSuppresionLigne.Size = new System.Drawing.Size(425, 51);
            this.lblSuppresionLigne.TabIndex = 0;
            this.lblSuppresionLigne.Text = "Suppression de ligne";
            // 
            // pnl_LigneSupp
            // 
            this.pnl_LigneSupp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_LigneSupp.Controls.Add(this.cbo_ligne);
            this.pnl_LigneSupp.Controls.Add(this.lbl_Ligne_a_Supprimer);
            this.pnl_LigneSupp.Location = new System.Drawing.Point(51, 119);
            this.pnl_LigneSupp.Name = "pnl_LigneSupp";
            this.pnl_LigneSupp.Size = new System.Drawing.Size(699, 141);
            this.pnl_LigneSupp.TabIndex = 1;
            // 
            // cbo_ligne
            // 
            this.cbo_ligne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ligne.FormattingEnabled = true;
            this.cbo_ligne.Location = new System.Drawing.Point(372, 57);
            this.cbo_ligne.Name = "cbo_ligne";
            this.cbo_ligne.Size = new System.Drawing.Size(187, 24);
            this.cbo_ligne.TabIndex = 3;
            this.cbo_ligne.SelectionChangeCommitted += new System.EventHandler(this.cbo_ligne_SelectionChangeCommitted);
            // 
            // lbl_Ligne_a_Supprimer
            // 
            this.lbl_Ligne_a_Supprimer.AutoSize = true;
            this.lbl_Ligne_a_Supprimer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ligne_a_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ligne_a_Supprimer.Location = new System.Drawing.Point(164, 52);
            this.lbl_Ligne_a_Supprimer.Name = "lbl_Ligne_a_Supprimer";
            this.lbl_Ligne_a_Supprimer.Size = new System.Drawing.Size(205, 29);
            this.lbl_Ligne_a_Supprimer.TabIndex = 2;
            this.lbl_Ligne_a_Supprimer.Text = "Ligne à suprimer :";
            // 
            // lbl_Messager_Attention
            // 
            this.lbl_Messager_Attention.AutoSize = true;
            this.lbl_Messager_Attention.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Messager_Attention.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Messager_Attention.Location = new System.Drawing.Point(105, 298);
            this.lbl_Messager_Attention.Name = "lbl_Messager_Attention";
            this.lbl_Messager_Attention.Size = new System.Drawing.Size(660, 20);
            this.lbl_Messager_Attention.TabIndex = 2;
            this.lbl_Messager_Attention.Text = "Attention, toute suppression est définitive , vous ne pourrez donc pas revenir en" +
    " arrière.";
            // 
            // pic_Attention
            // 
            this.pic_Attention.BackColor = System.Drawing.Color.Transparent;
            this.pic_Attention.BackgroundImage = global::SAE2_1.Properties.Resources.hidden_danger_1392698;
            this.pic_Attention.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Attention.Location = new System.Drawing.Point(67, 286);
            this.pic_Attention.Name = "pictureBox1";
            this.pic_Attention.Size = new System.Drawing.Size(32, 32);
            this.pic_Attention.TabIndex = 3;
            this.pic_Attention.TabStop = false;
            // 
            // cmd_Retour
            // 
            this.cmd_Retour.BackColor = System.Drawing.Color.Gray;
            this.cmd_Retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_Retour.ForeColor = System.Drawing.Color.White;
            this.cmd_Retour.Location = new System.Drawing.Point(51, 355);
            this.cmd_Retour.Name = "cmd_Retour";
            this.cmd_Retour.Size = new System.Drawing.Size(120, 66);
            this.cmd_Retour.TabIndex = 4;
            this.cmd_Retour.Text = "Retour";
            this.cmd_Retour.UseVisualStyleBackColor = false;
            // 
            // cmd_Valider
            // 
            this.cmd_Valider.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd_Valider.Enabled = false;
            this.cmd_Valider.ForeColor = System.Drawing.Color.White;
            this.cmd_Valider.Location = new System.Drawing.Point(630, 355);
            this.cmd_Valider.Name = "cmd_Valider";
            this.cmd_Valider.Size = new System.Drawing.Size(120, 66);
            this.cmd_Valider.TabIndex = 5;
            this.cmd_Valider.Text = "Valider";
            this.cmd_Valider.UseVisualStyleBackColor = false;
            this.cmd_Valider.Click += new System.EventHandler(this.cmd_Valider_Click);
            // 
            // cmd_visualiser
            // 
            this.cmd_visualiser.BackColor = System.Drawing.Color.White;
            this.cmd_visualiser.Location = new System.Drawing.Point(334, 355);
            this.cmd_visualiser.Name = "cmd_visualiser";
            this.cmd_visualiser.Size = new System.Drawing.Size(113, 66);
            this.cmd_visualiser.TabIndex = 6;
            this.cmd_visualiser.Text = "Visualiser";
            this.cmd_visualiser.UseVisualStyleBackColor = false;
            this.cmd_visualiser.Visible = false;
            this.cmd_visualiser.Click += new System.EventHandler(this.cmd_visualiser_Click);
            // 
            // SuppresionLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd_visualiser);
            this.Controls.Add(this.cmd_Valider);
            this.Controls.Add(this.cmd_Retour);
            this.Controls.Add(this.pic_Attention);
            this.Controls.Add(this.lbl_Messager_Attention);
            this.Controls.Add(this.pnl_LigneSupp);
            this.Controls.Add(this.lblSuppresionLigne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SuppresionLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppresionLigne";
            this.Load += new System.EventHandler(this.SuppresionLigne_Load);
            this.pnl_LigneSupp.ResumeLayout(false);
            this.pnl_LigneSupp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Attention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuppresionLigne;
        private System.Windows.Forms.Panel pnl_LigneSupp;
        private System.Windows.Forms.ComboBox cbo_ligne;
        private System.Windows.Forms.Label lbl_Ligne_a_Supprimer;
        private System.Windows.Forms.Label lbl_Messager_Attention;
        private System.Windows.Forms.PictureBox pic_Attention;
        private System.Windows.Forms.Button cmd_Retour;
        private System.Windows.Forms.Button cmd_Valider;
        private System.Windows.Forms.Button cmd_visualiser;
    }
}