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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.new_arret_btn = new System.Windows.Forms.Button();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_new_nom);
            this.panel1.Controls.Add(this.lbl2);
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
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(27, 69);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(238, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nouveau nom de la ligne :";
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
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.Color.Gray;
            this.cmd1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd1.ForeColor = System.Drawing.Color.White;
            this.cmd1.Location = new System.Drawing.Point(29, 381);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(108, 57);
            this.cmd1.TabIndex = 1;
            this.cmd1.Text = "Retour";
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2.ForeColor = System.Drawing.Color.White;
            this.cmd2.Location = new System.Drawing.Point(642, 381);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(146, 57);
            this.cmd2.TabIndex = 2;
            this.cmd2.Text = "Valider";
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 181);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(207, 176);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            this.flowLayoutPanel1.DragOver += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragOver);
            this.flowLayoutPanel1.DragLeave += new System.EventHandler(this.flowLayoutPanel1_DragLeave);
            // 
            // new_arret_btn
            // 
            this.new_arret_btn.BackColor = System.Drawing.Color.White;
            this.new_arret_btn.Location = new System.Drawing.Point(3, 3);
            this.new_arret_btn.Name = "new_arret_btn";
            this.new_arret_btn.Size = new System.Drawing.Size(145, 26);
            this.new_arret_btn.TabIndex = 4;
            this.new_arret_btn.Text = "Nouvelle Arret";
            this.new_arret_btn.UseVisualStyleBackColor = false;
            this.new_arret_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            this.new_arret_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMouseUp);
            // 
            // flp2
            // 
            this.flp2.AllowDrop = true;
            this.flp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flp2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flp2.BackgroundImage")));
            this.flp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp2.Location = new System.Drawing.Point(283, 381);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(44, 41);
            this.flp2.TabIndex = 6;
            this.flp2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.flp2.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp2_DragEnter);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(407, 299);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(328, 20);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Gliser-déposer dans l\'enplacement gauche";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.new_arret_btn);
            this.panel2.Location = new System.Drawing.Point(492, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 32);
            this.panel2.TabIndex = 8;
            // 
            // FormDeModifLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.flp2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDeModifLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeModifLigne";
            this.Load += new System.EventHandler(this.FormDeModifLigne_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_new_nom;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button new_arret_btn;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel panel2;
    }
}