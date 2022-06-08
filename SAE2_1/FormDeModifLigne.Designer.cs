namespace SAE2_1
{
    partial class FormDeModifLigne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeModifLigne));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_new_nom = new System.Windows.Forms.TextBox();
            this.lbl_nouveaux_nom_de_ligne = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.cmd_retour = new System.Windows.Forms.Button();
            this.cmd_valider = new System.Windows.Forms.Button();
            this.flp_arret = new System.Windows.Forms.FlowLayoutPanel();
            this.new_arret_btn = new System.Windows.Forms.Button();
            this.flp_poubelle = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_explication = new System.Windows.Forms.Label();
            this.pnl_nouvelle_arret = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_nouvelle_arret.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_new_nom);
            this.panel1.Controls.Add(this.lbl_nouveaux_nom_de_ligne);
            this.panel1.Controls.Add(this.lbl_titre);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 126);
            this.panel1.TabIndex = 0;
            // 
            // txt_new_nom
            // 
            this.txt_new_nom.Location = new System.Drawing.Point(271, 72);
            this.txt_new_nom.Name = "txt_new_nom";
            this.txt_new_nom.Size = new System.Drawing.Size(164, 22);
            this.txt_new_nom.TabIndex = 2;
            // 
            // lbl_nouveaux_nom_de_ligne
            // 
            this.lbl_nouveaux_nom_de_ligne.AutoSize = true;
            this.lbl_nouveaux_nom_de_ligne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nouveaux_nom_de_ligne.Location = new System.Drawing.Point(27, 69);
            this.lbl_nouveaux_nom_de_ligne.Name = "lbl_nouveaux_nom_de_ligne";
            this.lbl_nouveaux_nom_de_ligne.Size = new System.Drawing.Size(238, 25);
            this.lbl_nouveaux_nom_de_ligne.TabIndex = 1;
            this.lbl_nouveaux_nom_de_ligne.Text = "Nouveau nom de la ligne :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(200, 10);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(209, 29);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Modification Ligne";
            // 
            // cmd_retour
            // 
            this.cmd_retour.BackColor = System.Drawing.Color.Gray;
            this.cmd_retour.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmd_retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_retour.ForeColor = System.Drawing.Color.White;
            this.cmd_retour.Location = new System.Drawing.Point(29, 381);
            this.cmd_retour.Name = "cmd_retour";
            this.cmd_retour.Size = new System.Drawing.Size(108, 57);
            this.cmd_retour.TabIndex = 1;
            this.cmd_retour.Text = "Retour";
            this.cmd_retour.UseVisualStyleBackColor = false;
            // 
            // cmd_valider
            // 
            this.cmd_valider.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_valider.ForeColor = System.Drawing.Color.White;
            this.cmd_valider.Location = new System.Drawing.Point(598, 381);
            this.cmd_valider.Name = "cmd_valider";
            this.cmd_valider.Size = new System.Drawing.Size(146, 57);
            this.cmd_valider.TabIndex = 2;
            this.cmd_valider.Text = "Valider";
            this.cmd_valider.UseVisualStyleBackColor = false;
            this.cmd_valider.Click += new System.EventHandler(this.cmd_valider_Click);
            // 
            // flp_arret
            // 
            this.flp_arret.AllowDrop = true;
            this.flp_arret.AutoScroll = true;
            this.flp_arret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_arret.Location = new System.Drawing.Point(12, 181);
            this.flp_arret.Name = "flp_arret";
            this.flp_arret.Size = new System.Drawing.Size(207, 176);
            this.flp_arret.TabIndex = 3;
            this.flp_arret.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_arret_DragDrop);
            this.flp_arret.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_DragEnter);
            this.flp_arret.DragOver += new System.Windows.Forms.DragEventHandler(this.flp_arret_DragOver);
            this.flp_arret.DragLeave += new System.EventHandler(this.flp_arret_DragLeave);
            // 
            // new_arret_btn
            // 
            this.new_arret_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.new_arret_btn.ForeColor = System.Drawing.Color.White;
            this.new_arret_btn.Location = new System.Drawing.Point(3, 3);
            this.new_arret_btn.Name = "new_arret_btn";
            this.new_arret_btn.Size = new System.Drawing.Size(145, 26);
            this.new_arret_btn.TabIndex = 4;
            this.new_arret_btn.Text = "Nouvelle Arret";
            this.new_arret_btn.UseVisualStyleBackColor = false;
            this.new_arret_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            this.new_arret_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMouseUp);
            // 
            // flp_poubelle
            // 
            this.flp_poubelle.AllowDrop = true;
            this.flp_poubelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flp_poubelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flp_poubelle.BackgroundImage")));
            this.flp_poubelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_poubelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_poubelle.Location = new System.Drawing.Point(284, 381);
            this.flp_poubelle.Name = "flp_poubelle";
            this.flp_poubelle.Size = new System.Drawing.Size(48, 45);
            this.flp_poubelle.TabIndex = 6;
            this.flp_poubelle.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_poubelle_DragDrop);
            this.flp_poubelle.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_DragEnter);
            // 
            // lbl_explication
            // 
            this.lbl_explication.AutoSize = true;
            this.lbl_explication.BackColor = System.Drawing.Color.Transparent;
            this.lbl_explication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_explication.Location = new System.Drawing.Point(407, 299);
            this.lbl_explication.Name = "lbl_explication";
            this.lbl_explication.Size = new System.Drawing.Size(328, 20);
            this.lbl_explication.TabIndex = 7;
            this.lbl_explication.Text = "Gliser-déposer dans l\'enplacement gauche";
            // 
            // pnl_nouvelle_arret
            // 
            this.pnl_nouvelle_arret.BackColor = System.Drawing.Color.Transparent;
            this.pnl_nouvelle_arret.Controls.Add(this.new_arret_btn);
            this.pnl_nouvelle_arret.Location = new System.Drawing.Point(492, 204);
            this.pnl_nouvelle_arret.Name = "pnl_nouvelle_arret";
            this.pnl_nouvelle_arret.Size = new System.Drawing.Size(187, 32);
            this.pnl_nouvelle_arret.TabIndex = 8;
            // 
            // FormDeModifLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_nouvelle_arret);
            this.Controls.Add(this.lbl_explication);
            this.Controls.Add(this.flp_poubelle);
            this.Controls.Add(this.flp_arret);
            this.Controls.Add(this.cmd_valider);
            this.Controls.Add(this.cmd_retour);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDeModifLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeModifLigne";
            this.Load += new System.EventHandler(this.FormDeModifLigne_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_nouvelle_arret.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_new_nom;
        private System.Windows.Forms.Label lbl_nouveaux_nom_de_ligne;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Button cmd_retour;
        private System.Windows.Forms.Button cmd_valider;
        private System.Windows.Forms.FlowLayoutPanel flp_arret;
        private System.Windows.Forms.Button new_arret_btn;
        private System.Windows.Forms.FlowLayoutPanel flp_poubelle;
        private System.Windows.Forms.Label lbl_explication;
        private System.Windows.Forms.Panel pnl_nouvelle_arret;
    }
}