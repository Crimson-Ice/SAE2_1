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
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(24, 196);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(991, 184);
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arrêt de départ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arrêt de fin :";
            // 
            // lbl_arret_depart
            // 
            this.lbl_arret_depart.AutoSize = true;
            this.lbl_arret_depart.Location = new System.Drawing.Point(126, 107);
            this.lbl_arret_depart.Name = "lbl_arret_depart";
            this.lbl_arret_depart.Size = new System.Drawing.Size(41, 16);
            this.lbl_arret_depart.TabIndex = 7;
            this.lbl_arret_depart.Text = "NULL";
            // 
            // lbl_arret_fin
            // 
            this.lbl_arret_fin.AutoSize = true;
            this.lbl_arret_fin.Location = new System.Drawing.Point(126, 150);
            this.lbl_arret_fin.Name = "lbl_arret_fin";
            this.lbl_arret_fin.Size = new System.Drawing.Size(41, 16);
            this.lbl_arret_fin.TabIndex = 8;
            this.lbl_arret_fin.Text = "NULL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbl_arret_fin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_arret_depart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 197);
            this.panel1.TabIndex = 9;
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
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbl_nom_ligne);
            this.Controls.Add(this.hSB);
            this.Controls.Add(this.panel1);
            this.Name = "Form_affichage";
            this.Text = "Form_affichage";
            this.Load += new System.EventHandler(this.Form_affichage_Load);
            this.TextChanged += new System.EventHandler(this.Form_affichage_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar hSB;
        private System.Windows.Forms.Label lbl_nom_ligne;
        private System.Windows.Forms.PictureBox pb1;
    }
}