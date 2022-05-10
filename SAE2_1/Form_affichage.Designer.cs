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
            this.SuspendLayout();
            // 
            // hSB
            // 
            this.hSB.Location = new System.Drawing.Point(24, 383);
            this.hSB.Name = "hSB";
            this.hSB.Size = new System.Drawing.Size(991, 21);
            this.hSB.TabIndex = 2;
            this.hSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSB_Scroll);
            // 
            // lbl_nom_ligne
            // 
            this.lbl_nom_ligne.AutoSize = true;
            this.lbl_nom_ligne.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_ligne.Location = new System.Drawing.Point(15, 25);
            this.lbl_nom_ligne.Name = "lbl_nom_ligne";
            this.lbl_nom_ligne.Size = new System.Drawing.Size(0, 54);
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
            // Form_affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbl_nom_ligne);
            this.Controls.Add(this.hSB);
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