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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(254, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(208, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Création d\'arrêt";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(21, 32);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(103, 22);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nom d\'arrêt";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(25, 82);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(144, 22);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd2.Enabled = false;
            this.cmd2.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd2.Location = new System.Drawing.Point(544, 322);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(144, 78);
            this.cmd2.TabIndex = 3;
            this.cmd2.Text = "Valider";
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd1.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd1.Location = new System.Drawing.Point(39, 322);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(144, 78);
            this.cmd1.TabIndex = 3;
            this.cmd1.Text = "Retour";
            this.cmd1.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.cbo1);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.chk1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Location = new System.Drawing.Point(39, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 206);
            this.panel1.TabIndex = 4;
            // 
            // cbo1
            // 
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.Enabled = false;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(452, 82);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(159, 24);
            this.cbo1.TabIndex = 5;
            this.cbo1.SelectionChangeCommitted += new System.EventHandler(this.cbo1_SelectionChangeCommitted);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Enabled = false;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(448, 32);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(116, 22);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Arrêt existant";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1.Location = new System.Drawing.Point(245, 32);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(131, 24);
            this.chk1.TabIndex = 3;
            this.chk1.Text = "Arrêt existant";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.Click += new System.EventHandler(this.chk1_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(145, 149);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(193, 25);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Horaire premier bus :";
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "hh:mm";
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(344, 149);
            this.dtp1.MaxDate = new System.DateTime(9998, 12, 3, 0, 0, 0, 0);
            this.dtp1.MinDate = new System.DateTime(1753, 1, 4, 0, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowUpDown = true;
            this.dtp1.Size = new System.Drawing.Size(78, 28);
            this.dtp1.TabIndex = 7;
            this.dtp1.Value = new System.DateTime(2022, 5, 11, 0, 0, 0, 0);
            // 
            // Frm_createArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.lbl1);
            this.Name = "Frm_createArret";
            this.Text = "Création d\'arret";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl3;
        internal System.Windows.Forms.CheckBox chk1;
        internal System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label lbl4;
    }
}