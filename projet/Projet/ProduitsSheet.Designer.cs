namespace Projet
{
    partial class ProduitsSheet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.Label();
            this.codePostal = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.naissance = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label15);
            this.groupBox1.Controls.Add(this.Label14);
            this.groupBox1.Controls.Add(this.Label13);
            this.groupBox1.Controls.Add(this.Label9);
            this.groupBox1.Controls.Add(this.ville);
            this.groupBox1.Controls.Add(this.codePostal);
            this.groupBox1.Controls.Add(this.adresse);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.naissance);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Location = new System.Drawing.Point(285, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 235);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Intels :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Label15
            // 
            this.Label15.Location = new System.Drawing.Point(7, 123);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(77, 20);
            this.Label15.TabIndex = 14;
            this.Label15.Text = "Description : ";
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(7, 93);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(95, 20);
            this.Label14.TabIndex = 13;
            this.Label14.Text = "Prix d\'acquisition : ";
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(7, 62);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(86, 20);
            this.Label13.TabIndex = 12;
            this.Label13.Text = "Prix de vente : ";
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(7, 31);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(63, 20);
            this.Label9.TabIndex = 8;
            this.Label9.Text = "Nom : ";
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(90, 201);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(142, 20);
            this.ville.TabIndex = 7;
            // 
            // codePostal
            // 
            this.codePostal.Location = new System.Drawing.Point(90, 175);
            this.codePostal.Name = "codePostal";
            this.codePostal.Size = new System.Drawing.Size(142, 20);
            this.codePostal.TabIndex = 6;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(90, 149);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(142, 20);
            this.adresse.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(90, 123);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(165, 98);
            this.email.TabIndex = 4;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(108, 93);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(142, 20);
            this.tel.TabIndex = 3;
            // 
            // naissance
            // 
            this.naissance.Location = new System.Drawing.Point(90, 62);
            this.naissance.Name = "naissance";
            this.naissance.Size = new System.Drawing.Size(106, 20);
            this.naissance.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(90, 31);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(142, 20);
            this.nom.TabIndex = 0;
            // 
            // ProduitsSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProduitsSheet";
            this.Text = "ProduitsSheet";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label ville;
        private System.Windows.Forms.Label codePostal;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label naissance;
        private System.Windows.Forms.Label nom;
    }
}