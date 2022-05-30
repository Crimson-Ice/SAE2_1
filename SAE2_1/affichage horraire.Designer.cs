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
            this.cmd_Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoraire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoraire
            // 
            this.dgvHoraire.AllowUserToAddRows = false;
            this.dgvHoraire.AllowUserToDeleteRows = false;
            this.dgvHoraire.AllowUserToResizeColumns = false;
            this.dgvHoraire.AllowUserToResizeRows = false;
            this.dgvHoraire.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoraire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoraire.Location = new System.Drawing.Point(12, 12);
            this.dgvHoraire.Name = "dgvHoraire";
            this.dgvHoraire.ReadOnly = true;
            this.dgvHoraire.RowHeadersWidth = 51;
            this.dgvHoraire.RowTemplate.Height = 24;
            this.dgvHoraire.Size = new System.Drawing.Size(1006, 477);
            this.dgvHoraire.TabIndex = 0;
            // 
            // cmd_Retour
            // 
            this.cmd_Retour.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd_Retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_Retour.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Retour.Location = new System.Drawing.Point(12, 495);
            this.cmd_Retour.Name = "cmd_Retour";
            this.cmd_Retour.Size = new System.Drawing.Size(1006, 42);
            this.cmd_Retour.TabIndex = 4;
            this.cmd_Retour.Text = "Retour";
            this.cmd_Retour.UseVisualStyleBackColor = false;
            // 
            // affichage_horraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1030, 549);
            this.Controls.Add(this.cmd_Retour);
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
        private System.Windows.Forms.Button cmd_Retour;
    }
}