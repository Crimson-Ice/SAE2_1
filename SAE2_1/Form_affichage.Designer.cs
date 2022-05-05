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
            this.pnl = new System.Windows.Forms.Panel();
            this.hSB = new System.Windows.Forms.HScrollBar();
            this.lbl_nom_ligne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Cursor = System.Windows.Forms.Cursors.No;
            this.pnl.Location = new System.Drawing.Point(24, 182);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(982, 209);
            this.pnl.TabIndex = 1;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // hSB
            // 
            this.hSB.Location = new System.Drawing.Point(24, 394);
            this.hSB.Name = "hSB";
            this.hSB.Size = new System.Drawing.Size(982, 21);
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
            // Form_affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.lbl_nom_ligne);
            this.Controls.Add(this.hSB);
            this.Controls.Add(this.pnl);
            this.Name = "Form_affichage";
            this.Text = "Form_affichage";
            this.Load += new System.EventHandler(this.Form_affichage_Load);
            this.TextChanged += new System.EventHandler(this.Form_affichage_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.HScrollBar hSB;
        private System.Windows.Forms.Label lbl_nom_ligne;
    }
}