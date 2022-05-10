
namespace SAE2_1
{
    partial class CréationLigne
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cmd1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(242, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(302, 51);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Création Ligne";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(62, 124);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(157, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nom de la ligne :";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(67, 173);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(178, 22);
            this.txt1.TabIndex = 2;
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(62, 228);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(151, 25);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Nombre d\'arrêt :";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(67, 283);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(178, 22);
            this.txt2.TabIndex = 4;
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd1.Enabled = false;
            this.cmd1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd1.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd1.Location = new System.Drawing.Point(141, 333);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(122, 62);
            this.cmd1.TabIndex = 6;
            this.cmd1.Text = "Valider";
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(336, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 288);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlRemoved);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(629, 124);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt3.Size = new System.Drawing.Size(202, 288);
            this.txt3.TabIndex = 9;
            // 
            // cmd3
            // 
            this.cmd3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmd3.Enabled = false;
            this.cmd3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd3.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd3.Location = new System.Drawing.Point(511, 450);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(320, 79);
            this.cmd3.TabIndex = 10;
            this.cmd3.Text = "Terminer";
            this.cmd3.UseVisualStyleBackColor = false;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd2.Enabled = false;
            this.cmd2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd2.Location = new System.Drawing.Point(28, 333);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(107, 62);
            this.cmd2.TabIndex = 11;
            this.cmd2.Text = "Annuler";
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd4
            // 
            this.cmd4.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmd4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd4.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd4.Location = new System.Drawing.Point(67, 450);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(123, 79);
            this.cmd4.TabIndex = 12;
            this.cmd4.Text = "Accueil";
            this.cmd4.UseVisualStyleBackColor = false;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // CréationLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 553);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "CréationLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CréationLigne";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd4;
    }
}