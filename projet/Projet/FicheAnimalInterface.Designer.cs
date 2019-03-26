namespace Projet
{
    partial class FicheAnimalInterface
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
            this.ajouterRappel = new System.Windows.Forms.Button();
            this.modifierAnimal = new System.Windows.Forms.Button();
            this.supprimerAnimal = new System.Windows.Forms.Button();
            this.ajouterMaladie = new System.Windows.Forms.Button();
            this.modifierMaladie = new System.Windows.Forms.Button();
            this.genererOrdonnance = new System.Windows.Forms.Button();
            this.genererFacture = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.retourPageAnimal = new System.Windows.Forms.Button();
            this.nomProprietaire = new System.Windows.Forms.Label();
            this.nomEspece = new System.Windows.Forms.Label();
            this.nomRace = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.Label();
            this.dateNais = new System.Windows.Forms.Label();
            this.poids = new System.Windows.Forms.Label();
            this.listeMaladies = new System.Windows.Forms.Label();
            this.dateMaladies = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.listMaladie = new System.Windows.Forms.ListBox();
            this.datesMaladies = new System.Windows.Forms.ListBox();
            this.listCodes = new System.Windows.Forms.ListBox();
            this.listDescriptions = new System.Windows.Forms.ListBox();
            this.nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ajouterRappel
            // 
            this.ajouterRappel.Location = new System.Drawing.Point(87, 476);
            this.ajouterRappel.Name = "ajouterRappel";
            this.ajouterRappel.Size = new System.Drawing.Size(92, 23);
            this.ajouterRappel.TabIndex = 0;
            this.ajouterRappel.Text = "ajouterRappel";
            this.ajouterRappel.UseVisualStyleBackColor = true;
            // 
            // modifierAnimal
            // 
            this.modifierAnimal.Location = new System.Drawing.Point(12, 578);
            this.modifierAnimal.Name = "modifierAnimal";
            this.modifierAnimal.Size = new System.Drawing.Size(101, 23);
            this.modifierAnimal.TabIndex = 1;
            this.modifierAnimal.Text = "modifierAnimal";
            this.modifierAnimal.UseVisualStyleBackColor = true;
            this.modifierAnimal.Click += new System.EventHandler(this.modifierAnimal_Click);
            // 
            // supprimerAnimal
            // 
            this.supprimerAnimal.Location = new System.Drawing.Point(147, 578);
            this.supprimerAnimal.Name = "supprimerAnimal";
            this.supprimerAnimal.Size = new System.Drawing.Size(106, 23);
            this.supprimerAnimal.TabIndex = 2;
            this.supprimerAnimal.Text = "supprimerAnimal";
            this.supprimerAnimal.UseVisualStyleBackColor = true;
            this.supprimerAnimal.Click += new System.EventHandler(this.supprimerAnimal_Click);
            // 
            // ajouterMaladie
            // 
            this.ajouterMaladie.Location = new System.Drawing.Point(277, 578);
            this.ajouterMaladie.Name = "ajouterMaladie";
            this.ajouterMaladie.Size = new System.Drawing.Size(95, 23);
            this.ajouterMaladie.TabIndex = 3;
            this.ajouterMaladie.Text = "ajouterMaladie";
            this.ajouterMaladie.UseVisualStyleBackColor = true;
            // 
            // modifierMaladie
            // 
            this.modifierMaladie.Location = new System.Drawing.Point(397, 578);
            this.modifierMaladie.Name = "modifierMaladie";
            this.modifierMaladie.Size = new System.Drawing.Size(92, 23);
            this.modifierMaladie.TabIndex = 4;
            this.modifierMaladie.Text = "modifierMaladie";
            this.modifierMaladie.UseVisualStyleBackColor = true;
            // 
            // genererOrdonnance
            // 
            this.genererOrdonnance.Location = new System.Drawing.Point(516, 578);
            this.genererOrdonnance.Name = "genererOrdonnance";
            this.genererOrdonnance.Size = new System.Drawing.Size(115, 23);
            this.genererOrdonnance.TabIndex = 5;
            this.genererOrdonnance.Text = "genererOrdonnance";
            this.genererOrdonnance.UseVisualStyleBackColor = true;
            // 
            // genererFacture
            // 
            this.genererFacture.Location = new System.Drawing.Point(666, 578);
            this.genererFacture.Name = "genererFacture";
            this.genererFacture.Size = new System.Drawing.Size(93, 23);
            this.genererFacture.TabIndex = 6;
            this.genererFacture.Text = "genererFacture";
            this.genererFacture.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(369, 386);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 11;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(531, 386);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 13;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(450, 386);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 14;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // retourPageAnimal
            // 
            this.retourPageAnimal.Location = new System.Drawing.Point(22, 32);
            this.retourPageAnimal.Name = "retourPageAnimal";
            this.retourPageAnimal.Size = new System.Drawing.Size(104, 23);
            this.retourPageAnimal.TabIndex = 18;
            this.retourPageAnimal.Text = "retourPageAnimal";
            this.retourPageAnimal.UseVisualStyleBackColor = true;
            // 
            // nomProprietaire
            // 
            this.nomProprietaire.AutoSize = true;
            this.nomProprietaire.Location = new System.Drawing.Point(19, 93);
            this.nomProprietaire.Name = "nomProprietaire";
            this.nomProprietaire.Size = new System.Drawing.Size(80, 13);
            this.nomProprietaire.TabIndex = 19;
            this.nomProprietaire.Text = "nomProprietaire";
            // 
            // nomEspece
            // 
            this.nomEspece.AutoSize = true;
            this.nomEspece.Location = new System.Drawing.Point(36, 121);
            this.nomEspece.Name = "nomEspece";
            this.nomEspece.Size = new System.Drawing.Size(63, 13);
            this.nomEspece.TabIndex = 20;
            this.nomEspece.Text = "nomEspece";
            // 
            // nomRace
            // 
            this.nomRace.AutoSize = true;
            this.nomRace.Location = new System.Drawing.Point(43, 155);
            this.nomRace.Name = "nomRace";
            this.nomRace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomRace.Size = new System.Drawing.Size(53, 13);
            this.nomRace.TabIndex = 21;
            this.nomRace.Text = "nomRace";
            // 
            // sexe
            // 
            this.sexe.AutoSize = true;
            this.sexe.Location = new System.Drawing.Point(49, 190);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(29, 13);
            this.sexe.TabIndex = 22;
            this.sexe.Text = "sexe";
            // 
            // dateNais
            // 
            this.dateNais.AutoSize = true;
            this.dateNais.Location = new System.Drawing.Point(29, 220);
            this.dateNais.Name = "dateNais";
            this.dateNais.Size = new System.Drawing.Size(49, 13);
            this.dateNais.TabIndex = 23;
            this.dateNais.Text = "dateNais";
            // 
            // poids
            // 
            this.poids.AutoSize = true;
            this.poids.Location = new System.Drawing.Point(36, 254);
            this.poids.Name = "poids";
            this.poids.Size = new System.Drawing.Size(32, 13);
            this.poids.TabIndex = 24;
            this.poids.Text = "poids";
            // 
            // listeMaladies
            // 
            this.listeMaladies.AutoSize = true;
            this.listeMaladies.Location = new System.Drawing.Point(40, 325);
            this.listeMaladies.Name = "listeMaladies";
            this.listeMaladies.Size = new System.Drawing.Size(67, 13);
            this.listeMaladies.TabIndex = 25;
            this.listeMaladies.Text = "listeMaladies";
            // 
            // dateMaladies
            // 
            this.dateMaladies.AutoSize = true;
            this.dateMaladies.Location = new System.Drawing.Point(130, 316);
            this.dateMaladies.Name = "dateMaladies";
            this.dateMaladies.Size = new System.Drawing.Size(70, 13);
            this.dateMaladies.TabIndex = 26;
            this.dateMaladies.Text = "dateMaladies";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(358, 75);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(31, 13);
            this.code.TabIndex = 27;
            this.code.Text = "code";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(546, 75);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(58, 13);
            this.description.TabIndex = 28;
            this.description.Text = "description";
            // 
            // listMaladie
            // 
            this.listMaladie.FormattingEnabled = true;
            this.listMaladie.Location = new System.Drawing.Point(6, 341);
            this.listMaladie.Name = "listMaladie";
            this.listMaladie.Size = new System.Drawing.Size(120, 43);
            this.listMaladie.TabIndex = 35;
            // 
            // datesMaladies
            // 
            this.datesMaladies.FormattingEnabled = true;
            this.datesMaladies.Location = new System.Drawing.Point(133, 341);
            this.datesMaladies.Name = "datesMaladies";
            this.datesMaladies.Size = new System.Drawing.Size(120, 43);
            this.datesMaladies.TabIndex = 36;
            // 
            // listCodes
            // 
            this.listCodes.FormattingEnabled = true;
            this.listCodes.Location = new System.Drawing.Point(324, 93);
            this.listCodes.Name = "listCodes";
            this.listCodes.Size = new System.Drawing.Size(120, 225);
            this.listCodes.TabIndex = 37;
            // 
            // listDescriptions
            // 
            this.listDescriptions.FormattingEnabled = true;
            this.listDescriptions.Location = new System.Drawing.Point(511, 93);
            this.listDescriptions.Name = "listDescriptions";
            this.listDescriptions.Size = new System.Drawing.Size(120, 225);
            this.listDescriptions.TabIndex = 38;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(58, 75);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(27, 13);
            this.nom.TabIndex = 39;
            this.nom.Text = "nom";
            // 
            // FicheAnimalInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 613);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.listDescriptions);
            this.Controls.Add(this.listCodes);
            this.Controls.Add(this.datesMaladies);
            this.Controls.Add(this.listMaladie);
            this.Controls.Add(this.description);
            this.Controls.Add(this.code);
            this.Controls.Add(this.dateMaladies);
            this.Controls.Add(this.listeMaladies);
            this.Controls.Add(this.poids);
            this.Controls.Add(this.dateNais);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.nomRace);
            this.Controls.Add(this.nomEspece);
            this.Controls.Add(this.nomProprietaire);
            this.Controls.Add(this.retourPageAnimal);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.genererFacture);
            this.Controls.Add(this.genererOrdonnance);
            this.Controls.Add(this.modifierMaladie);
            this.Controls.Add(this.ajouterMaladie);
            this.Controls.Add(this.supprimerAnimal);
            this.Controls.Add(this.modifierAnimal);
            this.Controls.Add(this.ajouterRappel);
            this.Name = "FicheAnimalInterface";
            this.Text = "FicheAnimalInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouterRappel;
        private System.Windows.Forms.Button modifierAnimal;
        private System.Windows.Forms.Button supprimerAnimal;
        private System.Windows.Forms.Button ajouterMaladie;
        private System.Windows.Forms.Button modifierMaladie;
        private System.Windows.Forms.Button genererOrdonnance;
        private System.Windows.Forms.Button genererFacture;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button retourPageAnimal;
        private System.Windows.Forms.Label nomProprietaire;
        private System.Windows.Forms.Label nomEspece;
        private System.Windows.Forms.Label nomRace;
        private System.Windows.Forms.Label sexe;
        private System.Windows.Forms.Label dateNais;
        private System.Windows.Forms.Label poids;
        private System.Windows.Forms.Label listeMaladies;
        private System.Windows.Forms.Label dateMaladies;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.ListBox listMaladie;
        private System.Windows.Forms.ListBox datesMaladies;
        private System.Windows.Forms.ListBox listCodes;
        private System.Windows.Forms.ListBox listDescriptions;
        private System.Windows.Forms.Label nom;
    }
}