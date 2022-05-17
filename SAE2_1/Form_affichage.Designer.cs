namespace SAE2_1
{
    partial class Form_affichage
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
            this.hSB = new System.Windows.Forms.HScrollBar();
            this.lbl_nom_ligne = new System.Windows.Forms.Label();
            this.pb_LigneAffiche = new System.Windows.Forms.PictureBox();
            this.lbl_ArretDépart = new System.Windows.Forms.Label();
            this.lbl_ArretFin = new System.Windows.Forms.Label();
            this.lbl_arret_departAffiche = new System.Windows.Forms.Label();
            this.lbl_arret_finAffiche = new System.Windows.Forms.Label();
            this.pnl_Info_Ligne = new System.Windows.Forms.Panel();
            this.cmd_horaire = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LigneAffiche)).BeginInit();
            this.pnl_Info_Ligne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // hSB
            // 
            this.hSB.Location = new System.Drawing.Point(24, 402);
            this.hSB.Name = "hSB";
            this.hSB.Size = new System.Drawing.Size(991, 21);
            this.hSB.TabIndex = 2;
            this.hSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSB_Scroll);
            // 
            // lbl_nom_ligne
            // 
            this.lbl_nom_ligne.AutoSize = true;
            this.lbl_nom_ligne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_nom_ligne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_ligne.Location = new System.Drawing.Point(35, 24);
            this.lbl_nom_ligne.Name = "lbl_nom_ligne";
            this.lbl_nom_ligne.Size = new System.Drawing.Size(2, 48);
            this.lbl_nom_ligne.TabIndex = 3;
            // 
            // pb_LigneAffiche
            // 
            this.pb_LigneAffiche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_LigneAffiche.Location = new System.Drawing.Point(24, 215);
            this.pb_LigneAffiche.Name = "pb_LigneAffiche";
            this.pb_LigneAffiche.Size = new System.Drawing.Size(991, 184);
            this.pb_LigneAffiche.TabIndex = 4;
            this.pb_LigneAffiche.TabStop = false;
            // 
            // lbl_ArretDépart
            // 
            this.lbl_ArretDépart.AutoSize = true;
            this.lbl_ArretDépart.Location = new System.Drawing.Point(3, 107);
            this.lbl_ArretDépart.Name = "lbl_ArretDépart";
            this.lbl_ArretDépart.Size = new System.Drawing.Size(102, 16);
            this.lbl_ArretDépart.TabIndex = 5;
            this.lbl_ArretDépart.Text = "Arrêt de départ :";
            // 
            // lbl_ArretFin
            // 
            this.lbl_ArretFin.AutoSize = true;
            this.lbl_ArretFin.Location = new System.Drawing.Point(3, 150);
            this.lbl_ArretFin.Name = "lbl_ArretFin";
            this.lbl_ArretFin.Size = new System.Drawing.Size(76, 16);
            this.lbl_ArretFin.TabIndex = 6;
            this.lbl_ArretFin.Text = "Arrêt de fin :";
            // 
            // lbl_arret_departAffiche
            // 
            this.lbl_arret_departAffiche.AutoSize = true;
            this.lbl_arret_departAffiche.Location = new System.Drawing.Point(126, 107);
            this.lbl_arret_departAffiche.Name = "lbl_arret_departAffiche";
            this.lbl_arret_departAffiche.Size = new System.Drawing.Size(41, 16);
            this.lbl_arret_departAffiche.TabIndex = 7;
            this.lbl_arret_departAffiche.Text = "NULL";
            // 
            // lbl_arret_finAffiche
            // 
            this.lbl_arret_finAffiche.AutoSize = true;
            this.lbl_arret_finAffiche.Location = new System.Drawing.Point(126, 150);
            this.lbl_arret_finAffiche.Name = "lbl_arret_finAffiche";
            this.lbl_arret_finAffiche.Size = new System.Drawing.Size(41, 16);
            this.lbl_arret_finAffiche.TabIndex = 8;
            this.lbl_arret_finAffiche.Text = "NULL";
            // 
            // pnl_Info_Ligne
            // 
            this.pnl_Info_Ligne.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_Info_Ligne.Controls.Add(this.cmd_horaire);
            this.pnl_Info_Ligne.Controls.Add(this.lbl_arret_finAffiche);
            this.pnl_Info_Ligne.Controls.Add(this.lbl_ArretDépart);
            this.pnl_Info_Ligne.Controls.Add(this.lbl_arret_departAffiche);
            this.pnl_Info_Ligne.Controls.Add(this.lbl_ArretFin);
            this.pnl_Info_Ligne.Location = new System.Drawing.Point(24, 12);
            this.pnl_Info_Ligne.Name = "pnl_Info_Ligne";
            this.pnl_Info_Ligne.Size = new System.Drawing.Size(991, 197);
            this.pnl_Info_Ligne.TabIndex = 9;
            // 
            // cmd_horaire
            // 
            this.cmd_horaire.Location = new System.Drawing.Point(748, 123);
            this.cmd_horaire.Name = "cmd_horaire";
            this.cmd_horaire.Size = new System.Drawing.Size(185, 43);
            this.cmd_horaire.TabIndex = 9;
            this.cmd_horaire.Text = "Afficher les horaires";
            this.cmd_horaire.UseVisualStyleBackColor = true;
            this.cmd_horaire.Click += new System.EventHandler(this.cmd_horaire_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1013, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 184);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(-35, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 184);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Form_affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_LigneAffiche);
            this.Controls.Add(this.lbl_nom_ligne);
            this.Controls.Add(this.hSB);
            this.Controls.Add(this.pnl_Info_Ligne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_affichage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_affichage";
            this.Load += new System.EventHandler(this.Form_affichage_Load);
            this.TextChanged += new System.EventHandler(this.Form_affichage_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pb_LigneAffiche)).EndInit();
            this.pnl_Info_Ligne.ResumeLayout(false);
            this.pnl_Info_Ligne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar hSB;
        private System.Windows.Forms.Label lbl_nom_ligne;
        private System.Windows.Forms.PictureBox pb_LigneAffiche;
        private System.Windows.Forms.Label lbl_ArretDépart;
        private System.Windows.Forms.Label lbl_ArretFin;
        private System.Windows.Forms.Label lbl_arret_departAffiche;
        private System.Windows.Forms.Label lbl_arret_finAffiche;
        private System.Windows.Forms.Panel pnl_Info_Ligne;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button cmd_horaire;
    }
}