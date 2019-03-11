namespace Projet
{
    partial class Facture
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
            this.soinsList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.animalName = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soinsList
            // 
            this.soinsList.Location = new System.Drawing.Point(13, 79);
            this.soinsList.Name = "soinsList";
            this.soinsList.Size = new System.Drawing.Size(144, 184);
            this.soinsList.TabIndex = 0;
            this.soinsList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soins :";
            // 
            // animalName
            // 
            this.animalName.AutoSize = true;
            this.animalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalName.Location = new System.Drawing.Point(497, 44);
            this.animalName.Name = "animalName";
            this.animalName.Size = new System.Drawing.Size(130, 25);
            this.animalName.TabIndex = 2;
            this.animalName.Text = "NomAnimal";
            // 
            // nameClient
            // 
            this.nameClient.AutoSize = true;
            this.nameClient.Location = new System.Drawing.Point(499, 79);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(55, 13);
            this.nameClient.TabIndex = 3;
            this.nameClient.Text = "NomClient";
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(376, 242);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(100, 20);
            this.prix.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prix :";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(376, 384);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(100, 23);
            this.generate.TabIndex = 6;
            this.generate.Text = "Generate Facture";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.nameClient);
            this.Controls.Add(this.animalName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soinsList);
            this.Name = "Facture";
            this.Text = "Facture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView soinsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label animalName;
        private System.Windows.Forms.Label nameClient;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generate;
    }
}