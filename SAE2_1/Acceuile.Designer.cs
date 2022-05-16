
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
            this.cmdRechercheItineraire = new System.Windows.Forms.Button();
            this.cmdListeLigne = new System.Windows.Forms.Button();
            this.cmdCréationLigne = new System.Windows.Forms.Button();
            this.cmdModifLigne = new System.Windows.Forms.Button();
            this.cmdSuppLigne = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRechercheItineraire
            // 
            this.cmdRechercheItineraire.BackColor = System.Drawing.Color.White;
            this.cmdRechercheItineraire.Location = new System.Drawing.Point(39, 25);
            this.cmdRechercheItineraire.Name = "cmdRechercheItineraire";
            this.cmdRechercheItineraire.Size = new System.Drawing.Size(158, 76);
            this.cmdRechercheItineraire.TabIndex = 0;
            this.cmdRechercheItineraire.Text = "Recherche itinéraire";
            this.cmdRechercheItineraire.UseVisualStyleBackColor = false;
            this.cmdRechercheItineraire.Click += new System.EventHandler(this.cmdRechercheItineraire_Click);
            // 
            // cmdListeLigne
            // 
            this.cmdListeLigne.BackColor = System.Drawing.Color.White;
            this.cmdListeLigne.Location = new System.Drawing.Point(39, 107);
            this.cmdListeLigne.Name = "cmdListeLigne";
            this.cmdListeLigne.Size = new System.Drawing.Size(158, 76);
            this.cmdListeLigne.TabIndex = 1;
            this.cmdListeLigne.Text = "Liste Ligne";
            this.cmdListeLigne.UseVisualStyleBackColor = false;
            this.cmdListeLigne.Click += new System.EventHandler(this.cmd_ListeLigne_Click);
            // 
            // cmdCréationLigne
            // 
            this.cmdCréationLigne.BackColor = System.Drawing.Color.White;
            this.cmdCréationLigne.Location = new System.Drawing.Point(39, 189);
            this.cmdCréationLigne.Name = "cmdCréationLigne";
            this.cmdCréationLigne.Size = new System.Drawing.Size(158, 76);
            this.cmdCréationLigne.TabIndex = 2;
            this.cmdCréationLigne.Text = "Création Ligne";
            this.cmdCréationLigne.UseVisualStyleBackColor = false;
            this.cmdCréationLigne.Click += new System.EventHandler(this.cmd_CreationLigne_Click);
            // 
            // cmdModifLigne
            // 
            this.cmdModifLigne.BackColor = System.Drawing.Color.White;
            this.cmdModifLigne.Location = new System.Drawing.Point(39, 271);
            this.cmdModifLigne.Name = "cmdModifLigne";
            this.cmdModifLigne.Size = new System.Drawing.Size(158, 76);
            this.cmdModifLigne.TabIndex = 3;
            this.cmdModifLigne.Text = "Modification Ligne";
            this.cmdModifLigne.UseVisualStyleBackColor = false;
            this.cmdModifLigne.Click += new System.EventHandler(this.cmd_ModifLigne_Click);
            // 
            // cmdSuppLigne
            // 
            this.cmdSuppLigne.BackColor = System.Drawing.Color.White;
            this.cmdSuppLigne.Location = new System.Drawing.Point(39, 353);
            this.cmdSuppLigne.Name = "cmdSuppLigne";
            this.cmdSuppLigne.Size = new System.Drawing.Size(158, 76);
            this.cmdSuppLigne.TabIndex = 4;
            this.cmdSuppLigne.Text = "Supression Ligne";
            this.cmdSuppLigne.UseVisualStyleBackColor = false;
            this.cmdSuppLigne.Click += new System.EventHandler(this.cmd_SuppLigne_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SAE2_1.Properties.Resources.tul_plan_simplifi_poteaux_2021_bat_page_0001;
            this.pictureBox1.Location = new System.Drawing.Point(232, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Acceuille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE2_1.Properties.Resources._6637000_simple_fond_bleu_abstraite_pour_la_conception_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdSuppLigne);
            this.Controls.Add(this.cmdModifLigne);
            this.Controls.Add(this.cmdCréationLigne);
            this.Controls.Add(this.cmdListeLigne);
            this.Controls.Add(this.cmdRechercheItineraire);
            this.Name = "Acceuille";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRechercheItineraire;
        private System.Windows.Forms.Button cmdListeLigne;
        private System.Windows.Forms.Button cmdCréationLigne;
        private System.Windows.Forms.Button cmdModifLigne;
        private System.Windows.Forms.Button cmdSuppLigne;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

