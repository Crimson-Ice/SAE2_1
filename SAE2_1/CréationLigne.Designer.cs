
namespace SAE2_1
{
    partial class CréationLigne
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
            this.lbl_TitreCreationLigne = new System.Windows.Forms.Label();
            this.lbl_NomLigne_cree = new System.Windows.Forms.Label();
            this.txt_NomLigneCree = new System.Windows.Forms.TextBox();
            this.lbl_NombreArret = new System.Windows.Forms.Label();
            this.txt_NombreArret = new System.Windows.Forms.TextBox();
            this.cmd_Valider = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flp_ArretCree = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_AfficheArretCree = new System.Windows.Forms.TextBox();
            this.cmd_Terminer = new System.Windows.Forms.Button();
            this.cmd_Annuler = new System.Windows.Forms.Button();
            this.cmd_Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TitreCreationLigne
            // 
            this.lbl_TitreCreationLigne.AutoSize = true;
            this.lbl_TitreCreationLigne.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TitreCreationLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitreCreationLigne.Location = new System.Drawing.Point(242, 32);
            this.lbl_TitreCreationLigne.Name = "lbl_TitreCreationLigne";
            this.lbl_TitreCreationLigne.Size = new System.Drawing.Size(302, 51);
            this.lbl_TitreCreationLigne.TabIndex = 0;
            this.lbl_TitreCreationLigne.Text = "Création Ligne";
            // 
            // lbl_NomLigne_cree
            // 
            this.lbl_NomLigne_cree.AutoSize = true;
            this.lbl_NomLigne_cree.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomLigne_cree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomLigne_cree.Location = new System.Drawing.Point(62, 124);
            this.lbl_NomLigne_cree.Name = "lbl_NomLigne_cree";
            this.lbl_NomLigne_cree.Size = new System.Drawing.Size(157, 25);
            this.lbl_NomLigne_cree.TabIndex = 1;
            this.lbl_NomLigne_cree.Text = "Nom de la ligne :";
            // 
            // txt_NomLigneCree
            // 
            this.txt_NomLigneCree.Location = new System.Drawing.Point(67, 173);
            this.txt_NomLigneCree.Name = "txt_NomLigneCree";
            this.txt_NomLigneCree.Size = new System.Drawing.Size(178, 22);
            this.txt_NomLigneCree.TabIndex = 2;
            this.txt_NomLigneCree.Enter += new System.EventHandler(this.txt_NomLigneCree_Enter);
            // 
            // lbl_NombreArret
            // 
            this.lbl_NombreArret.AutoSize = true;
            this.lbl_NombreArret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NombreArret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreArret.Location = new System.Drawing.Point(62, 228);
            this.lbl_NombreArret.Name = "lbl_NombreArret";
            this.lbl_NombreArret.Size = new System.Drawing.Size(151, 25);
            this.lbl_NombreArret.TabIndex = 3;
            this.lbl_NombreArret.Text = "Nombre d\'arrêt :";
            // 
            // txt_NombreArret
            // 
            this.txt_NombreArret.Location = new System.Drawing.Point(67, 283);
            this.txt_NombreArret.Name = "txt_NombreArret";
            this.txt_NombreArret.Size = new System.Drawing.Size(178, 22);
            this.txt_NombreArret.TabIndex = 4;
            this.txt_NombreArret.Enter += new System.EventHandler(this.txt_NomLigneCree_Enter);
            // 
            // cmd_Valider
            // 
            this.cmd_Valider.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd_Valider.Enabled = false;
            this.cmd_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Valider.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Valider.Location = new System.Drawing.Point(141, 333);
            this.cmd_Valider.Name = "cmd_Valider";
            this.cmd_Valider.Size = new System.Drawing.Size(122, 62);
            this.cmd_Valider.TabIndex = 6;
            this.cmd_Valider.Text = "Valider";
            this.cmd_Valider.UseVisualStyleBackColor = false;
            this.cmd_Valider.Click += new System.EventHandler(this.cmd_Valider_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // flp_ArretCree
            // 
            this.flp_ArretCree.AutoScroll = true;
            this.flp_ArretCree.BackColor = System.Drawing.Color.Transparent;
            this.flp_ArretCree.Location = new System.Drawing.Point(336, 124);
            this.flp_ArretCree.Name = "flp_ArretCree";
            this.flp_ArretCree.Size = new System.Drawing.Size(200, 288);
            this.flp_ArretCree.TabIndex = 8;
            this.flp_ArretCree.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flp_ArretCree_ControlRemoved);
            // 
            // txt_AfficheArretCree
            // 
            this.txt_AfficheArretCree.Location = new System.Drawing.Point(629, 124);
            this.txt_AfficheArretCree.Multiline = true;
            this.txt_AfficheArretCree.Name = "txt_AfficheArretCree";
            this.txt_AfficheArretCree.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_AfficheArretCree.Size = new System.Drawing.Size(202, 288);
            this.txt_AfficheArretCree.TabIndex = 9;
            // 
            // cmd_Terminer
            // 
            this.cmd_Terminer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd_Terminer.Enabled = false;
            this.cmd_Terminer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_Terminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Terminer.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Terminer.Location = new System.Drawing.Point(511, 450);
            this.cmd_Terminer.Name = "cmd_Terminer";
            this.cmd_Terminer.Size = new System.Drawing.Size(320, 79);
            this.cmd_Terminer.TabIndex = 10;
            this.cmd_Terminer.Text = "Terminer";
            this.cmd_Terminer.UseVisualStyleBackColor = false;
            this.cmd_Terminer.Click += new System.EventHandler(this.cmd_Terminer_Click);
            // 
            // cmd_Annuler
            // 
            this.cmd_Annuler.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd_Annuler.Enabled = false;
            this.cmd_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Annuler.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Annuler.Location = new System.Drawing.Point(28, 333);
            this.cmd_Annuler.Name = "cmd_Annuler";
            this.cmd_Annuler.Size = new System.Drawing.Size(107, 62);
            this.cmd_Annuler.TabIndex = 11;
            this.cmd_Annuler.Text = "Annuler";
            this.cmd_Annuler.UseVisualStyleBackColor = false;
            this.cmd_Annuler.Click += new System.EventHandler(this.cmd_Annuler_Click);
            // 
            // cmd_Retour
            // 
            this.cmd_Retour.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd_Retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Retour.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Retour.Location = new System.Drawing.Point(67, 450);
            this.cmd_Retour.Name = "cmd_Retour";
            this.cmd_Retour.Size = new System.Drawing.Size(123, 79);
            this.cmd_Retour.TabIndex = 12;
            this.cmd_Retour.Text = "Retour";
            this.cmd_Retour.UseVisualStyleBackColor = false;
            // 
            // CréationLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 553);
            this.Controls.Add(this.cmd_Retour);
            this.Controls.Add(this.cmd_Annuler);
            this.Controls.Add(this.cmd_Terminer);
            this.Controls.Add(this.txt_AfficheArretCree);
            this.Controls.Add(this.flp_ArretCree);
            this.Controls.Add(this.cmd_Valider);
            this.Controls.Add(this.txt_NombreArret);
            this.Controls.Add(this.lbl_NombreArret);
            this.Controls.Add(this.txt_NomLigneCree);
            this.Controls.Add(this.lbl_NomLigne_cree);
            this.Controls.Add(this.lbl_TitreCreationLigne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CréationLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CréationLigne";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TitreCreationLigne;
        private System.Windows.Forms.Label lbl_NomLigne_cree;
        private System.Windows.Forms.TextBox txt_NomLigneCree;
        private System.Windows.Forms.Label lbl_NombreArret;
        private System.Windows.Forms.TextBox txt_NombreArret;
        private System.Windows.Forms.Button cmd_Valider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FlowLayoutPanel flp_ArretCree;
        private System.Windows.Forms.TextBox txt_AfficheArretCree;
        private System.Windows.Forms.Button cmd_Terminer;
        private System.Windows.Forms.Button cmd_Annuler;
        private System.Windows.Forms.Button cmd_Retour;
    }
}