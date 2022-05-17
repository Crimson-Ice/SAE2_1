namespace SAE2_1
{
    partial class Frm_createArret
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
            this.components = new System.ComponentModel.Container();
            this.lbl_CreationArret = new System.Windows.Forms.Label();
            this.lbl_NomArret = new System.Windows.Forms.Label();
            this.txt_NomArret = new System.Windows.Forms.TextBox();
            this.cmd_Valider = new System.Windows.Forms.Button();
            this.cmd_Retour = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Attention = new System.Windows.Forms.PictureBox();
            this.lbl_PrecisionPremierHoraire = new System.Windows.Forms.Label();
            this.dtp_HorairePremierBus = new System.Windows.Forms.DateTimePicker();
            this.lbl_HorairePremierBus = new System.Windows.Forms.Label();
            this.cbo_ArretExistant = new System.Windows.Forms.ComboBox();
            this.lbl_ArretExistant = new System.Windows.Forms.Label();
            this.chk_ArretExistant = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Attention)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CreationArret
            // 
            this.lbl_CreationArret.AutoSize = true;
            this.lbl_CreationArret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreationArret.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreationArret.Location = new System.Drawing.Point(254, 18);
            this.lbl_CreationArret.Name = "lbl_CreationArret";
            this.lbl_CreationArret.Size = new System.Drawing.Size(208, 32);
            this.lbl_CreationArret.TabIndex = 0;
            this.lbl_CreationArret.Text = "Création d\'arrêt";
            // 
            // lbl_NomArret
            // 
            this.lbl_NomArret.AutoSize = true;
            this.lbl_NomArret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomArret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomArret.Location = new System.Drawing.Point(21, 32);
            this.lbl_NomArret.Name = "lbl_NomArret";
            this.lbl_NomArret.Size = new System.Drawing.Size(103, 22);
            this.lbl_NomArret.TabIndex = 1;
            this.lbl_NomArret.Text = "Nom d\'arrêt";
            // 
            // txt_NomArret
            // 
            this.txt_NomArret.Location = new System.Drawing.Point(25, 82);
            this.txt_NomArret.Name = "txt_NomArret";
            this.txt_NomArret.Size = new System.Drawing.Size(144, 22);
            this.txt_NomArret.TabIndex = 2;
            this.txt_NomArret.TextChanged += new System.EventHandler(this.txt_NomArret_TextChanged);
            // 
            // cmd_Valider
            // 
            this.cmd_Valider.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd_Valider.Enabled = false;
            this.cmd_Valider.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Valider.Location = new System.Drawing.Point(544, 333);
            this.cmd_Valider.Name = "cmd_Valider";
            this.cmd_Valider.Size = new System.Drawing.Size(144, 78);
            this.cmd_Valider.TabIndex = 3;
            this.cmd_Valider.Text = "Valider";
            this.cmd_Valider.UseVisualStyleBackColor = false;
            this.cmd_Valider.Click += new System.EventHandler(this.cmd_Valider_Click);
            // 
            // cmd_Retour
            // 
            this.cmd_Retour.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd_Retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_Retour.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Retour.Location = new System.Drawing.Point(39, 333);
            this.cmd_Retour.Name = "cmd_Retour";
            this.cmd_Retour.Size = new System.Drawing.Size(144, 78);
            this.cmd_Retour.TabIndex = 3;
            this.cmd_Retour.Text = "Retour";
            this.cmd_Retour.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pb_Attention);
            this.panel1.Controls.Add(this.lbl_PrecisionPremierHoraire);
            this.panel1.Controls.Add(this.dtp_HorairePremierBus);
            this.panel1.Controls.Add(this.lbl_HorairePremierBus);
            this.panel1.Controls.Add(this.cbo_ArretExistant);
            this.panel1.Controls.Add(this.lbl_ArretExistant);
            this.panel1.Controls.Add(this.chk_ArretExistant);
            this.panel1.Controls.Add(this.lbl_NomArret);
            this.panel1.Controls.Add(this.txt_NomArret);
            this.panel1.Location = new System.Drawing.Point(39, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 235);
            this.panel1.TabIndex = 4;
            // 
            // pb_Attention
            // 
            this.pb_Attention.BackColor = System.Drawing.Color.Transparent;
            this.pb_Attention.BackgroundImage = global::SAE2_1.Properties.Resources.hidden_danger_1392698;
            this.pb_Attention.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Attention.Location = new System.Drawing.Point(92, 179);
            this.pb_Attention.Name = "pb_Attention";
            this.pb_Attention.Size = new System.Drawing.Size(24, 26);
            this.pb_Attention.TabIndex = 9;
            this.pb_Attention.TabStop = false;
            // 
            // lbl_PrecisionPremierHoraire
            // 
            this.lbl_PrecisionPremierHoraire.AutoSize = true;
            this.lbl_PrecisionPremierHoraire.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PrecisionPremierHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecisionPremierHoraire.Location = new System.Drawing.Point(122, 185);
            this.lbl_PrecisionPremierHoraire.Name = "lbl_PrecisionPremierHoraire";
            this.lbl_PrecisionPremierHoraire.Size = new System.Drawing.Size(394, 20);
            this.lbl_PrecisionPremierHoraire.TabIndex = 8;
            this.lbl_PrecisionPremierHoraire.Text = "L\'horaire du premier bus doit être supérieur à 5 : 00";
            // 
            // dtp_HorairePremierBus
            // 
            this.dtp_HorairePremierBus.CustomFormat = "hh:mm";
            this.dtp_HorairePremierBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_HorairePremierBus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_HorairePremierBus.Location = new System.Drawing.Point(364, 140);
            this.dtp_HorairePremierBus.MaxDate = new System.DateTime(9998, 12, 3, 0, 0, 0, 0);
            this.dtp_HorairePremierBus.MinDate = new System.DateTime(1753, 1, 4, 0, 0, 0, 0);
            this.dtp_HorairePremierBus.Name = "dtp_HorairePremierBus";
            this.dtp_HorairePremierBus.ShowUpDown = true;
            this.dtp_HorairePremierBus.Size = new System.Drawing.Size(78, 28);
            this.dtp_HorairePremierBus.TabIndex = 7;
            this.dtp_HorairePremierBus.Value = new System.DateTime(2022, 5, 11, 0, 0, 0, 0);
            // 
            // lbl_HorairePremierBus
            // 
            this.lbl_HorairePremierBus.AutoSize = true;
            this.lbl_HorairePremierBus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HorairePremierBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HorairePremierBus.Location = new System.Drawing.Point(165, 140);
            this.lbl_HorairePremierBus.Name = "lbl_HorairePremierBus";
            this.lbl_HorairePremierBus.Size = new System.Drawing.Size(193, 25);
            this.lbl_HorairePremierBus.TabIndex = 6;
            this.lbl_HorairePremierBus.Text = "Horaire premier bus :";
            // 
            // cbo_ArretExistant
            // 
            this.cbo_ArretExistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ArretExistant.Enabled = false;
            this.cbo_ArretExistant.FormattingEnabled = true;
            this.cbo_ArretExistant.Location = new System.Drawing.Point(452, 82);
            this.cbo_ArretExistant.Name = "cbo_ArretExistant";
            this.cbo_ArretExistant.Size = new System.Drawing.Size(159, 24);
            this.cbo_ArretExistant.TabIndex = 5;
            this.cbo_ArretExistant.SelectionChangeCommitted += new System.EventHandler(this.cbo_ArretExistant_SelectionChangeCommitted);
            // 
            // lbl_ArretExistant
            // 
            this.lbl_ArretExistant.AutoSize = true;
            this.lbl_ArretExistant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ArretExistant.Enabled = false;
            this.lbl_ArretExistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArretExistant.Location = new System.Drawing.Point(448, 32);
            this.lbl_ArretExistant.Name = "lbl_ArretExistant";
            this.lbl_ArretExistant.Size = new System.Drawing.Size(116, 22);
            this.lbl_ArretExistant.TabIndex = 4;
            this.lbl_ArretExistant.Text = "Arrêt existant";
            // 
            // chk_ArretExistant
            // 
            this.chk_ArretExistant.AutoSize = true;
            this.chk_ArretExistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ArretExistant.Location = new System.Drawing.Point(245, 32);
            this.chk_ArretExistant.Name = "chk_ArretExistant";
            this.chk_ArretExistant.Size = new System.Drawing.Size(131, 24);
            this.chk_ArretExistant.TabIndex = 3;
            this.chk_ArretExistant.Text = "Arrêt existant";
            this.chk_ArretExistant.UseVisualStyleBackColor = true;
            this.chk_ArretExistant.Click += new System.EventHandler(this.chk_ArretExistant_Click);
            // 
            // Frm_createArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmd_Retour);
            this.Controls.Add(this.cmd_Valider);
            this.Controls.Add(this.lbl_CreationArret);
            this.Name = "Frm_createArret";
            this.Text = "Création d\'arret";
            this.Load += new System.EventHandler(this.Frm_createArret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Attention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CreationArret;
        private System.Windows.Forms.Label lbl_NomArret;
        private System.Windows.Forms.Button cmd_Valider;
        internal System.Windows.Forms.TextBox txt_NomArret;
        private System.Windows.Forms.Button cmd_Retour;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ArretExistant;
        internal System.Windows.Forms.CheckBox chk_ArretExistant;
        internal System.Windows.Forms.ComboBox cbo_ArretExistant;
        private System.Windows.Forms.Label lbl_HorairePremierBus;
        internal System.Windows.Forms.DateTimePicker dtp_HorairePremierBus;
        private System.Windows.Forms.Label lbl_PrecisionPremierHoraire;
        private System.Windows.Forms.PictureBox pb_Attention;
    }
}