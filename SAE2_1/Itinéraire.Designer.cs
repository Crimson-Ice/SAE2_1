
namespace SAE2_1
{
    partial class Itinéraire
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
            this.lbl_Recherche_itinéraire = new System.Windows.Forms.Label();
            this.lblç_arret_depart = new System.Windows.Forms.Label();
            this.lbl_arret_fin = new System.Windows.Forms.Label();
            this.cbo_arretDepart = new System.Windows.Forms.ComboBox();
            this.cbo_arret_fin = new System.Windows.Forms.ComboBox();
            this.chk_FiltreHoraireDebut = new System.Windows.Forms.CheckBox();
            this.chk_FiltreHoraireFin = new System.Windows.Forms.CheckBox();
            this.Dtp_hroaireDebut = new System.Windows.Forms.DateTimePicker();
            this.Dtp_HoraireFin = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd_Valider = new System.Windows.Forms.Button();
            this.cmd_Retour = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Recherche_itinéraire
            // 
            this.lbl_Recherche_itinéraire.AutoSize = true;
            this.lbl_Recherche_itinéraire.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Recherche_itinéraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recherche_itinéraire.Location = new System.Drawing.Point(279, 30);
            this.lbl_Recherche_itinéraire.Name = "lbl_Recherche_itinéraire";
            this.lbl_Recherche_itinéraire.Size = new System.Drawing.Size(408, 46);
            this.lbl_Recherche_itinéraire.TabIndex = 0;
            this.lbl_Recherche_itinéraire.Text = "Recherche d\'itinéraire";
            // 
            // lblç_arret_depart
            // 
            this.lblç_arret_depart.AutoSize = true;
            this.lblç_arret_depart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblç_arret_depart.Location = new System.Drawing.Point(54, 54);
            this.lblç_arret_depart.Name = "lblç_arret_depart";
            this.lblç_arret_depart.Size = new System.Drawing.Size(185, 29);
            this.lblç_arret_depart.TabIndex = 1;
            this.lblç_arret_depart.Text = "Arrêt de départ :";
            // 
            // lbl_arret_fin
            // 
            this.lbl_arret_fin.AutoSize = true;
            this.lbl_arret_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arret_fin.Location = new System.Drawing.Point(505, 54);
            this.lbl_arret_fin.Name = "lbl_arret_fin";
            this.lbl_arret_fin.Size = new System.Drawing.Size(141, 29);
            this.lbl_arret_fin.TabIndex = 2;
            this.lbl_arret_fin.Text = "Arrêt de fin :";
            // 
            // cbo_arretDepart
            // 
            this.cbo_arretDepart.FormattingEnabled = true;
            this.cbo_arretDepart.IntegralHeight = false;
            this.cbo_arretDepart.ItemHeight = 16;
            this.cbo_arretDepart.Location = new System.Drawing.Point(249, 59);
            this.cbo_arretDepart.MaxDropDownItems = 4;
            this.cbo_arretDepart.Name = "cbo_arretDepart";
            this.cbo_arretDepart.Size = new System.Drawing.Size(166, 24);
            this.cbo_arretDepart.TabIndex = 3;
            // 
            // cbo_arret_fin
            // 
            this.cbo_arret_fin.FormattingEnabled = true;
            this.cbo_arret_fin.IntegralHeight = false;
            this.cbo_arret_fin.Location = new System.Drawing.Point(664, 57);
            this.cbo_arret_fin.MaxDropDownItems = 4;
            this.cbo_arret_fin.Name = "cbo_arret_fin";
            this.cbo_arret_fin.Size = new System.Drawing.Size(158, 24);
            this.cbo_arret_fin.TabIndex = 4;
            // 
            // chk_FiltreHoraireDebut
            // 
            this.chk_FiltreHoraireDebut.AutoSize = true;
            this.chk_FiltreHoraireDebut.BackColor = System.Drawing.Color.Transparent;
            this.chk_FiltreHoraireDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_FiltreHoraireDebut.Location = new System.Drawing.Point(34, 37);
            this.chk_FiltreHoraireDebut.Name = "chk_FiltreHoraireDebut";
            this.chk_FiltreHoraireDebut.Size = new System.Drawing.Size(206, 29);
            this.chk_FiltreHoraireDebut.TabIndex = 5;
            this.chk_FiltreHoraireDebut.Text = "Filtre horaire debut :";
            this.chk_FiltreHoraireDebut.UseVisualStyleBackColor = false;
            this.chk_FiltreHoraireDebut.Click += new System.EventHandler(this.chk_FiltreHoraireDebut_Click);
            // 
            // chk_FiltreHoraireFin
            // 
            this.chk_FiltreHoraireFin.AutoSize = true;
            this.chk_FiltreHoraireFin.BackColor = System.Drawing.Color.Transparent;
            this.chk_FiltreHoraireFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_FiltreHoraireFin.Location = new System.Drawing.Point(473, 37);
            this.chk_FiltreHoraireFin.Name = "chk_FiltreHoraireFin";
            this.chk_FiltreHoraireFin.Size = new System.Drawing.Size(204, 29);
            this.chk_FiltreHoraireFin.TabIndex = 6;
            this.chk_FiltreHoraireFin.Text = "Filtre horaire de fin :";
            this.chk_FiltreHoraireFin.UseVisualStyleBackColor = false;
            this.chk_FiltreHoraireFin.Click += new System.EventHandler(this.chk_FiltreHoraireFin_Click);
            // 
            // Dtp_hroaireDebut
            // 
            this.Dtp_hroaireDebut.CustomFormat = "HH:mm";
            this.Dtp_hroaireDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_hroaireDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_hroaireDebut.Location = new System.Drawing.Point(260, 28);
            this.Dtp_hroaireDebut.Name = "Dtp_hroaireDebut";
            this.Dtp_hroaireDebut.ShowUpDown = true;
            this.Dtp_hroaireDebut.Size = new System.Drawing.Size(111, 38);
            this.Dtp_hroaireDebut.TabIndex = 7;
            this.Dtp_hroaireDebut.Visible = false;
            // 
            // Dtp_HoraireFin
            // 
            this.Dtp_HoraireFin.CustomFormat = "HH:mm";
            this.Dtp_HoraireFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_HoraireFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_HoraireFin.Location = new System.Drawing.Point(712, 28);
            this.Dtp_HoraireFin.Name = "Dtp_HoraireFin";
            this.Dtp_HoraireFin.ShowUpDown = true;
            this.Dtp_HoraireFin.Size = new System.Drawing.Size(111, 38);
            this.Dtp_HoraireFin.TabIndex = 8;
            this.Dtp_HoraireFin.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblç_arret_depart);
            this.panel1.Controls.Add(this.cbo_arretDepart);
            this.panel1.Controls.Add(this.lbl_arret_fin);
            this.panel1.Controls.Add(this.cbo_arret_fin);
            this.panel1.Location = new System.Drawing.Point(40, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 133);
            this.panel1.TabIndex = 9;
            // 
            // cmd_Valider
            // 
            this.cmd_Valider.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmd_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Valider.ForeColor = System.Drawing.Color.White;
            this.cmd_Valider.Location = new System.Drawing.Point(739, 409);
            this.cmd_Valider.Name = "cmd_Valider";
            this.cmd_Valider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmd_Valider.Size = new System.Drawing.Size(179, 60);
            this.cmd_Valider.TabIndex = 10;
            this.cmd_Valider.Text = "Valider";
            this.cmd_Valider.UseVisualStyleBackColor = false;
            this.cmd_Valider.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd_Retour
            // 
            this.cmd_Retour.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd_Retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Retour.ForeColor = System.Drawing.Color.White;
            this.cmd_Retour.Location = new System.Drawing.Point(40, 413);
            this.cmd_Retour.Name = "cmd_Retour";
            this.cmd_Retour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmd_Retour.Size = new System.Drawing.Size(179, 56);
            this.cmd_Retour.TabIndex = 11;
            this.cmd_Retour.Text = "Retour";
            this.cmd_Retour.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.chk_FiltreHoraireDebut);
            this.panel2.Controls.Add(this.Dtp_hroaireDebut);
            this.panel2.Controls.Add(this.chk_FiltreHoraireFin);
            this.panel2.Controls.Add(this.Dtp_HoraireFin);
            this.panel2.Location = new System.Drawing.Point(40, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 100);
            this.panel2.TabIndex = 12;
            // 
            // Itinéraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmd_Retour);
            this.Controls.Add(this.cmd_Valider);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Recherche_itinéraire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Itinéraire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itinéraire";
            this.Load += new System.EventHandler(this.Itinéraire_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Recherche_itinéraire;
        private System.Windows.Forms.Label lblç_arret_depart;
        private System.Windows.Forms.Label lbl_arret_fin;
        private System.Windows.Forms.ComboBox cbo_arretDepart;
        private System.Windows.Forms.ComboBox cbo_arret_fin;
        private System.Windows.Forms.CheckBox chk_FiltreHoraireDebut;
        private System.Windows.Forms.CheckBox chk_FiltreHoraireFin;
        private System.Windows.Forms.DateTimePicker Dtp_hroaireDebut;
        private System.Windows.Forms.DateTimePicker Dtp_HoraireFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmd_Valider;
        private System.Windows.Forms.Button cmd_Retour;
        private System.Windows.Forms.Panel panel2;
    }
}