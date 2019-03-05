namespace Projet
{
    partial class NewProduct
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
            this.dAcq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.des = new System.Windows.Forms.RichTextBox();
            this.pAcq = new System.Windows.Forms.TextBox();
            this.pVente = new System.Windows.Forms.TextBox();
            this.pNom = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.Label();
            this.acqP = new System.Windows.Forms.Label();
            this.sellingP = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.Label();
            this.codePostal = new System.Windows.Forms.Label();
            this.re = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.re);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dAcq);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.pAcq);
            this.groupBox1.Controls.Add(this.pVente);
            this.groupBox1.Controls.Add(this.pNom);
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.acqP);
            this.groupBox1.Controls.Add(this.sellingP);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.ville);
            this.groupBox1.Controls.Add(this.codePostal);
            this.groupBox1.Location = new System.Drawing.Point(264, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 297);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Intels :";
            // 
            // dAcq
            // 
            this.dAcq.Location = new System.Drawing.Point(132, 122);
            this.dAcq.Name = "dAcq";
            this.dAcq.Size = new System.Drawing.Size(100, 20);
            this.dAcq.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date d\'acquisition : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(132, 257);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 19;
            this.insert.Text = "Inserer";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(132, 175);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(126, 76);
            this.des.TabIndex = 18;
            this.des.Text = "";
            // 
            // pAcq
            // 
            this.pAcq.Location = new System.Drawing.Point(132, 93);
            this.pAcq.Name = "pAcq";
            this.pAcq.Size = new System.Drawing.Size(100, 20);
            this.pAcq.TabIndex = 17;
            // 
            // pVente
            // 
            this.pVente.Location = new System.Drawing.Point(132, 62);
            this.pVente.Name = "pVente";
            this.pVente.Size = new System.Drawing.Size(100, 20);
            this.pVente.TabIndex = 16;
            // 
            // pNom
            // 
            this.pNom.Location = new System.Drawing.Point(132, 31);
            this.pNom.Name = "pNom";
            this.pNom.Size = new System.Drawing.Size(100, 20);
            this.pNom.TabIndex = 15;
            this.pNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(6, 181);
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
            // re
            // 
            this.re.Location = new System.Drawing.Point(132, 149);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(100, 20);
            this.re.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reference du produit : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox dAcq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.RichTextBox des;
        private System.Windows.Forms.TextBox pAcq;
        private System.Windows.Forms.TextBox pVente;
        private System.Windows.Forms.TextBox pNom;
        private System.Windows.Forms.TextBox re;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}