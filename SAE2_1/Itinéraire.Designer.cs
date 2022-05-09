
namespace SAE2_1
{
    partial class Itinéraire
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.Dtp1 = new System.Windows.Forms.DateTimePicker();
            this.Dtp2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(87, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(408, 46);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Recherche d\'itinéraire";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(41, 52);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(185, 29);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Arrêt de départ :";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(547, 54);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(141, 29);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Arrêt de fin :";
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.IntegralHeight = false;
            this.cbo1.ItemHeight = 16;
            this.cbo1.Location = new System.Drawing.Point(249, 59);
            this.cbo1.MaxDropDownItems = 4;
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 24);
            this.cbo1.TabIndex = 3;
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.IntegralHeight = false;
            this.cbo2.Location = new System.Drawing.Point(714, 59);
            this.cbo2.MaxDropDownItems = 4;
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(121, 24);
            this.cbo2.TabIndex = 4;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.BackColor = System.Drawing.Color.Transparent;
            this.chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1.Location = new System.Drawing.Point(79, 351);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(206, 29);
            this.chk1.TabIndex = 5;
            this.chk1.Text = "Filtre horaire debut :";
            this.chk1.UseVisualStyleBackColor = false;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.BackColor = System.Drawing.Color.Transparent;
            this.chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2.Location = new System.Drawing.Point(539, 351);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(204, 29);
            this.chk2.TabIndex = 6;
            this.chk2.Text = "Filtre horaire de fin :";
            this.chk2.UseVisualStyleBackColor = false;
            this.chk2.Click += new System.EventHandler(this.chk2_Click);
            // 
            // Dtp1
            // 
            this.Dtp1.CustomFormat = "HH:mm";
            this.Dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp1.Location = new System.Drawing.Point(303, 346);
            this.Dtp1.Name = "Dtp1";
            this.Dtp1.ShowUpDown = true;
            this.Dtp1.Size = new System.Drawing.Size(111, 38);
            this.Dtp1.TabIndex = 7;
            this.Dtp1.Visible = false;
            // 
            // Dtp2
            // 
            this.Dtp2.CustomFormat = "HH:mm";
            this.Dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp2.Location = new System.Drawing.Point(768, 346);
            this.Dtp2.Name = "Dtp2";
            this.Dtp2.ShowUpDown = true;
            this.Dtp2.Size = new System.Drawing.Size(111, 38);
            this.Dtp2.TabIndex = 8;
            this.Dtp2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.cbo1);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.cbo2);
            this.panel1.Location = new System.Drawing.Point(40, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 133);
            this.panel1.TabIndex = 9;
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd1.ForeColor = System.Drawing.Color.White;
            this.cmd1.Location = new System.Drawing.Point(714, 491);
            this.cmd1.Name = "cmd1";
            this.cmd1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmd1.Size = new System.Drawing.Size(204, 84);
            this.cmd1.TabIndex = 10;
            this.cmd1.Text = "Valider";
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2.ForeColor = System.Drawing.Color.White;
            this.cmd2.Location = new System.Drawing.Point(40, 491);
            this.cmd2.Name = "cmd2";
            this.cmd2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmd2.Size = new System.Drawing.Size(204, 84);
            this.cmd2.TabIndex = 11;
            this.cmd2.Text = "Retour";
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // Itinéraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 625);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dtp2);
            this.Controls.Add(this.Dtp1);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.lbl1);
            this.Name = "Itinéraire";
            this.Text = "Itinéraire";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.DateTimePicker Dtp1;
        private System.Windows.Forms.DateTimePicker Dtp2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
    }
}