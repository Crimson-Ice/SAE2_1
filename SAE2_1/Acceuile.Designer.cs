
namespace SAE2_1
{
    partial class Acceuille
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.Color.White;
            this.cmd1.Location = new System.Drawing.Point(39, 25);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(158, 76);
            this.cmd1.TabIndex = 0;
            this.cmd1.Text = "Recherche itinéraire";
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.Color.White;
            this.cmd2.Location = new System.Drawing.Point(39, 107);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(158, 76);
            this.cmd2.TabIndex = 1;
            this.cmd2.Text = "Liste Ligne";
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.BackColor = System.Drawing.Color.White;
            this.cmd3.Location = new System.Drawing.Point(39, 189);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(158, 76);
            this.cmd3.TabIndex = 2;
            this.cmd3.Text = "Création Ligne";
            this.cmd3.UseVisualStyleBackColor = false;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd4
            // 
            this.cmd4.BackColor = System.Drawing.Color.White;
            this.cmd4.Location = new System.Drawing.Point(39, 271);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(158, 76);
            this.cmd4.TabIndex = 3;
            this.cmd4.Text = "Modification Ligne";
            this.cmd4.UseVisualStyleBackColor = false;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.BackColor = System.Drawing.Color.White;
            this.cmd5.Location = new System.Drawing.Point(39, 353);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(158, 76);
            this.cmd5.TabIndex = 4;
            this.cmd5.Text = "Supression Ligne";
            this.cmd5.UseVisualStyleBackColor = false;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Image = global::SAE2_1.Properties.Resources.tul_plan_simplifi_poteaux_2021_bat_page_0001;
            this.pb1.Location = new System.Drawing.Point(232, 25);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(512, 404);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            // 
            // Acceuille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Name = "Acceuille";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.PictureBox pb1;
    }
}

