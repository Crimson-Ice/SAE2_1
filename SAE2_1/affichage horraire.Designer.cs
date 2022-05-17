namespace SAE2_1
{
    partial class affichage_horraire
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
            this.dgvHoraire = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoraire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoraire
            // 
            this.dgvHoraire.AllowUserToAddRows = false;
            this.dgvHoraire.AllowUserToDeleteRows = false;
            this.dgvHoraire.AllowUserToResizeColumns = false;
            this.dgvHoraire.AllowUserToResizeRows = false;
            this.dgvHoraire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoraire.Location = new System.Drawing.Point(50, 40);
            this.dgvHoraire.Name = "dgvHoraire";
            this.dgvHoraire.ReadOnly = true;
            this.dgvHoraire.RowHeadersWidth = 51;
            this.dgvHoraire.RowTemplate.Height = 24;
            this.dgvHoraire.Size = new System.Drawing.Size(719, 383);
            this.dgvHoraire.TabIndex = 0;
            // 
            // affichage_horraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHoraire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "affichage_horraire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "affichage_horraire";
            this.Load += new System.EventHandler(this.affichage_horraire_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoraire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoraire;
    }
}