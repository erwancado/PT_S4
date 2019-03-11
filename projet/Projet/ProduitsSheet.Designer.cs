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
            this.desc = new System.Windows.Forms.Label();
            this.acqP = new System.Windows.Forms.Label();
            this.sellingP = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.Label();
            this.codePostal = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.pa = new System.Windows.Forms.Label();
            this.pv = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.acqP);
            this.groupBox1.Controls.Add(this.sellingP);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.ville);
            this.groupBox1.Controls.Add(this.codePostal);
            this.groupBox1.Controls.Add(this.adresse);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.pa);
            this.groupBox1.Controls.Add(this.pv);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Location = new System.Drawing.Point(285, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 235);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Intels :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(7, 123);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(77, 20);
            this.desc.TabIndex = 14;
            this.desc.Text = "Description : ";
            // 
            // acqP
            // 
            this.acqP.Location = new System.Drawing.Point(7, 93);
            this.acqP.Name = "acqP";
            this.acqP.Size = new System.Drawing.Size(95, 20);
            this.acqP.TabIndex = 13;
            this.acqP.Text = "Prix d\'acquisition : ";
            // 
            // sellingP
            // 
            this.sellingP.Location = new System.Drawing.Point(7, 62);
            this.sellingP.Name = "sellingP";
            this.sellingP.Size = new System.Drawing.Size(86, 20);
            this.sellingP.TabIndex = 12;
            this.sellingP.Text = "Prix de vente : ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(7, 31);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(63, 20);
            this.name.TabIndex = 8;
            this.name.Text = "Nom : ";
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
            // d
            // 
            this.d.Location = new System.Drawing.Point(90, 123);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(165, 98);
            this.d.TabIndex = 4;
            // 
            // pa
            // 
            this.pa.Location = new System.Drawing.Point(108, 93);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(142, 20);
            this.pa.TabIndex = 3;
            // 
            // pv
            // 
            this.pv.Location = new System.Drawing.Point(90, 62);
            this.pv.Name = "pv";
            this.pv.Size = new System.Drawing.Size(106, 20);
            this.pv.TabIndex = 2;
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
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label acqP;
        private System.Windows.Forms.Label sellingP;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label ville;
        private System.Windows.Forms.Label codePostal;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label pa;
        private System.Windows.Forms.Label pv;
        private System.Windows.Forms.Label nom;
    }
}