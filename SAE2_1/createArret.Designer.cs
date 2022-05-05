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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(208, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(208, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Création d\'arrêt";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(68, 89);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(103, 22);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nom d\'arrêt";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(72, 140);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(144, 22);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmd2.Enabled = false;
            this.cmd2.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd2.Location = new System.Drawing.Point(413, 201);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(144, 78);
            this.cmd2.TabIndex = 3;
            this.cmd2.Text = "Valider";
            this.cmd2.UseVisualStyleBackColor = false;
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd1.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd1.Location = new System.Drawing.Point(72, 201);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(144, 78);
            this.cmd1.TabIndex = 3;
            this.cmd1.Text = "Retour";
            this.cmd1.UseVisualStyleBackColor = false;
            // 
            // Frm_createArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 311);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Frm_createArret";
            this.Text = "Création d\'arret";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button cmd2;
        internal System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}