namespace SAE2_1
{
    partial class SuppresionLigne
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.cboligne = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.btnvisualiser = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(186, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(425, 51);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Suppression de ligne";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.cboligne);
            this.pnl1.Controls.Add(this.lbl2);
            this.pnl1.Location = new System.Drawing.Point(51, 119);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(699, 141);
            this.pnl1.TabIndex = 1;
            // 
            // cboligne
            // 
            this.cboligne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboligne.FormattingEnabled = true;
            this.cboligne.Location = new System.Drawing.Point(372, 57);
            this.cboligne.Name = "cboligne";
            this.cboligne.Size = new System.Drawing.Size(187, 24);
            this.cboligne.TabIndex = 3;
            this.cboligne.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(164, 52);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(205, 29);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Ligne à suprimer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attention, toute suppression est définitive , vous ne pourrez donc pas revenir en" +
    " arrière.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SAE2_1.Properties.Resources.hidden_danger_1392698;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(67, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.Color.Gray;
            this.cmd1.ForeColor = System.Drawing.Color.White;
            this.cmd1.Location = new System.Drawing.Point(51, 355);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(120, 66);
            this.cmd1.TabIndex = 4;
            this.cmd1.Text = "Retour";
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd2.Enabled = false;
            this.cmd2.ForeColor = System.Drawing.Color.White;
            this.cmd2.Location = new System.Drawing.Point(630, 355);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(120, 66);
            this.cmd2.TabIndex = 5;
            this.cmd2.Text = "Valider";
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // btnvisualiser
            // 
            this.btnvisualiser.BackColor = System.Drawing.Color.White;
            this.btnvisualiser.Location = new System.Drawing.Point(334, 355);
            this.btnvisualiser.Name = "btnvisualiser";
            this.btnvisualiser.Size = new System.Drawing.Size(113, 66);
            this.btnvisualiser.TabIndex = 6;
            this.btnvisualiser.Text = "Visualiser";
            this.btnvisualiser.UseVisualStyleBackColor = false;
            this.btnvisualiser.Visible = false;
            this.btnvisualiser.Click += new System.EventHandler(this.btnvisualiser_Click);
            // 
            // SuppresionLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvisualiser);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SuppresionLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppresionLigne";
            this.Load += new System.EventHandler(this.SuppresionLigne_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.ComboBox cboligne;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button btnvisualiser;
    }
}