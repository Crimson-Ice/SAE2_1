﻿namespace SAE2_1
{
    partial class ModificationLigne
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Location = new System.Drawing.Point(48, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 204);
            this.panel1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(169, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(462, 54);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Modification de Ligne";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(236, 50);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(232, 32);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Ligne à modifier :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.Color.White;
            this.cmd1.Location = new System.Drawing.Point(88, 380);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(107, 41);
            this.cmd1.TabIndex = 2;
            this.cmd1.Text = "Retour";
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.Color.White;
            this.cmd2.Location = new System.Drawing.Point(601, 380);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(107, 41);
            this.cmd2.TabIndex = 3;
            this.cmd2.Text = "Modifier";
            this.cmd2.UseVisualStyleBackColor = false;
            // 
            // ModificationLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel1);
            this.Name = "ModificationLigne";
            this.Text = "ModificationLigne";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
    }
}