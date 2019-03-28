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
            this.components = new System.ComponentModel.Container();
            this.ajouterRappel = new System.Windows.Forms.Button();
            this.modifierAnimal = new System.Windows.Forms.Button();
            this.supprimerAnimal = new System.Windows.Forms.Button();
            this.genererOrdonnance = new System.Windows.Forms.Button();
            this.genererFacture = new System.Windows.Forms.Button();
            this.retourPageAnimal = new System.Windows.Forms.Button();
            this.nomProprietaire = new System.Windows.Forms.Label();
            this.nomEspece = new System.Windows.Forms.Label();
            this.nomRace = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.Label();
            this.dateNais = new System.Windows.Forms.Label();
            this.poids = new System.Windows.Forms.Label();
            this.listeMaladies = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.listOfDiseases = new System.Windows.Forms.ListView();
            this.listMaladies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateMaladies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listOfSoins = new System.Windows.Forms.ListView();
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuSoins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMaladie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSoins.SuspendLayout();
            this.contextMenuMaladie.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajouterRappel
            // 
            this.ajouterRappel.Location = new System.Drawing.Point(480, 578);
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
            // genererOrdonnance
            // 
            this.genererOrdonnance.Location = new System.Drawing.Point(623, 578);
            this.genererOrdonnance.Name = "genererOrdonnance";
            this.genererOrdonnance.Size = new System.Drawing.Size(115, 23);
            this.genererOrdonnance.TabIndex = 5;
            this.genererOrdonnance.Text = "genererOrdonnance";
            this.genererOrdonnance.UseVisualStyleBackColor = true;
            // 
            // genererFacture
            // 
            this.genererFacture.Location = new System.Drawing.Point(768, 578);
            this.genererFacture.Name = "genererFacture";
            this.genererFacture.Size = new System.Drawing.Size(93, 23);
            this.genererFacture.TabIndex = 6;
            this.genererFacture.Text = "genererFacture";
            this.genererFacture.UseVisualStyleBackColor = true;
            // 
            // retourPageAnimal
            // 
            this.retourPageAnimal.Location = new System.Drawing.Point(22, 32);
            this.retourPageAnimal.Name = "retourPageAnimal";
            this.retourPageAnimal.Size = new System.Drawing.Size(104, 23);
            this.retourPageAnimal.TabIndex = 18;
            this.retourPageAnimal.Text = "retourPageAnimal";
            this.retourPageAnimal.UseVisualStyleBackColor = true;
            this.retourPageAnimal.Click += new System.EventHandler(this.retourPageAnimal_Click);
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
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(546, 75);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(58, 13);
            this.description.TabIndex = 28;
            this.description.Text = "description";
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
            // listOfDiseases
            // 
            this.listOfDiseases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listMaladies,
            this.dateMaladies});
            this.listOfDiseases.ContextMenuStrip = this.contextMenuMaladie;
            this.listOfDiseases.Location = new System.Drawing.Point(22, 354);
            this.listOfDiseases.Name = "listOfDiseases";
            this.listOfDiseases.Size = new System.Drawing.Size(285, 173);
            this.listOfDiseases.TabIndex = 40;
            this.listOfDiseases.UseCompatibleStateImageBehavior = false;
            this.listOfDiseases.View = System.Windows.Forms.View.Details;
            // 
            // listMaladies
            // 
            this.listMaladies.Text = "listMaladies";
            // 
            // dateMaladies
            // 
            this.dateMaladies.Text = "dateMaladies";
            this.dateMaladies.Width = 62;
            // 
            // listOfSoins
            // 
            this.listOfSoins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Desc,
            this.columnHeader4});
            this.listOfSoins.ContextMenuStrip = this.contextMenuSoins;
            this.listOfSoins.Location = new System.Drawing.Point(397, 121);
            this.listOfSoins.Name = "listOfSoins";
            this.listOfSoins.Size = new System.Drawing.Size(502, 256);
            this.listOfSoins.TabIndex = 41;
            this.listOfSoins.UseCompatibleStateImageBehavior = false;
            this.listOfSoins.View = System.Windows.Forms.View.Details;
            // 
            // Desc
            // 
            this.Desc.DisplayIndex = 1;
            this.Desc.Text = "Description";
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            this.columnHeader4.Text = "code";
            // 
            // contextMenuSoins
            // 
            this.contextMenuSoins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuSoins.Name = "contextMenuSoins";
            this.contextMenuSoins.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // contextMenuMaladie
            // 
            this.contextMenuMaladie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.contextMenuMaladie.Name = "contextMenuMaladie";
            this.contextMenuMaladie.Size = new System.Drawing.Size(181, 92);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // FicheAnimalInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 613);
            this.Controls.Add(this.listOfSoins);
            this.Controls.Add(this.listOfDiseases);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.description);
            this.Controls.Add(this.listeMaladies);
            this.Controls.Add(this.poids);
            this.Controls.Add(this.dateNais);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.nomRace);
            this.Controls.Add(this.nomEspece);
            this.Controls.Add(this.nomProprietaire);
            this.Controls.Add(this.retourPageAnimal);
            this.Controls.Add(this.genererFacture);
            this.Controls.Add(this.genererOrdonnance);
            this.Controls.Add(this.supprimerAnimal);
            this.Controls.Add(this.modifierAnimal);
            this.Controls.Add(this.ajouterRappel);
            this.Name = "FicheAnimalInterface";
            this.Text = "FicheAnimalInterface";
            this.contextMenuSoins.ResumeLayout(false);
            this.contextMenuMaladie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouterRappel;
        private System.Windows.Forms.Button modifierAnimal;
        private System.Windows.Forms.Button supprimerAnimal;
        private System.Windows.Forms.Button genererOrdonnance;
        private System.Windows.Forms.Button genererFacture;
        private System.Windows.Forms.Button retourPageAnimal;
        private System.Windows.Forms.Label nomProprietaire;
        private System.Windows.Forms.Label nomEspece;
        private System.Windows.Forms.Label nomRace;
        private System.Windows.Forms.Label sexe;
        private System.Windows.Forms.Label dateNais;
        private System.Windows.Forms.Label poids;
        private System.Windows.Forms.Label listeMaladies;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.ListView listOfDiseases;
        private System.Windows.Forms.ColumnHeader listMaladies;
        private System.Windows.Forms.ColumnHeader dateMaladies;
        private System.Windows.Forms.ListView listOfSoins;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuSoins;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuMaladie;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
    }
}