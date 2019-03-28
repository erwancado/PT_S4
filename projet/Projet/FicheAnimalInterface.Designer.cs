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
            this.genererOrdonnance = new System.Windows.Forms.Button();
            this.genererFacture = new System.Windows.Forms.Button();
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
            this.empty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomMaladies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateMaladies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuMaladie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listReminders = new System.Windows.Forms.ListView();
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuSoins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMaladie.SuspendLayout();
            this.contextMenuSoins.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajouterRappel
            // 
            this.ajouterRappel.Location = new System.Drawing.Point(476, 558);
            this.ajouterRappel.Name = "ajouterRappel";
            this.ajouterRappel.Size = new System.Drawing.Size(92, 23);
            this.ajouterRappel.TabIndex = 0;
            this.ajouterRappel.Text = "ajouterRappel";
            this.ajouterRappel.UseVisualStyleBackColor = true;
            this.ajouterRappel.Click += new System.EventHandler(this.ajouterRappel_Click);
            // 
            // modifierAnimal
            // 
            this.modifierAnimal.Location = new System.Drawing.Point(71, 558);
            this.modifierAnimal.Name = "modifierAnimal";
            this.modifierAnimal.Size = new System.Drawing.Size(128, 23);
            this.modifierAnimal.TabIndex = 1;
            this.modifierAnimal.Text = "modifierAnimal";
            this.modifierAnimal.UseVisualStyleBackColor = true;
            this.modifierAnimal.Click += new System.EventHandler(this.modifierAnimal_Click);
            // 
            // genererOrdonnance
            // 
            this.genererOrdonnance.Location = new System.Drawing.Point(624, 558);
            this.genererOrdonnance.Name = "genererOrdonnance";
            this.genererOrdonnance.Size = new System.Drawing.Size(115, 23);
            this.genererOrdonnance.TabIndex = 5;
            this.genererOrdonnance.Text = "genererOrdonnance";
            this.genererOrdonnance.UseVisualStyleBackColor = true;
            this.genererOrdonnance.Click += new System.EventHandler(this.genererOrdonnance_Click);
            // 
            // genererFacture
            // 
            this.genererFacture.Location = new System.Drawing.Point(771, 558);
            this.genererFacture.Name = "genererFacture";
            this.genererFacture.Size = new System.Drawing.Size(93, 23);
            this.genererFacture.TabIndex = 6;
            this.genererFacture.Text = "genererFacture";
            this.genererFacture.UseVisualStyleBackColor = true;
            // 
            // nomProprietaire
            // 
            this.nomProprietaire.AutoSize = true;
            this.nomProprietaire.Location = new System.Drawing.Point(19, 75);
            this.nomProprietaire.Name = "nomProprietaire";
            this.nomProprietaire.Size = new System.Drawing.Size(90, 13);
            this.nomProprietaire.TabIndex = 19;
            this.nomProprietaire.Text = "Nom propriétaire :";
            // 
            // nomEspece
            // 
            this.nomEspece.AutoSize = true;
            this.nomEspece.Location = new System.Drawing.Point(60, 103);
            this.nomEspece.Name = "nomEspece";
            this.nomEspece.Size = new System.Drawing.Size(49, 13);
            this.nomEspece.TabIndex = 20;
            this.nomEspece.Text = "Espece :";
            // 
            // nomRace
            // 
            this.nomRace.AutoSize = true;
            this.nomRace.Location = new System.Drawing.Point(70, 131);
            this.nomRace.Name = "nomRace";
            this.nomRace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nomRace.Size = new System.Drawing.Size(39, 13);
            this.nomRace.TabIndex = 21;
            this.nomRace.Text = "Race :";
            // 
            // sexe
            // 
            this.sexe.AutoSize = true;
            this.sexe.Location = new System.Drawing.Point(70, 159);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(37, 13);
            this.sexe.TabIndex = 22;
            this.sexe.Text = "Sexe :";
            // 
            // dateNais
            // 
            this.dateNais.AutoSize = true;
            this.dateNais.Location = new System.Drawing.Point(5, 181);
            this.dateNais.Name = "dateNais";
            this.dateNais.Size = new System.Drawing.Size(102, 13);
            this.dateNais.TabIndex = 23;
            this.dateNais.Text = "Date de naissance :";
            // 
            // poids
            // 
            this.poids.AutoSize = true;
            this.poids.Location = new System.Drawing.Point(68, 204);
            this.poids.Name = "poids";
            this.poids.Size = new System.Drawing.Size(39, 13);
            this.poids.TabIndex = 24;
            this.poids.Text = "Poids :";
            // 
            // listeMaladies
            // 
            this.listeMaladies.AutoSize = true;
            this.listeMaladies.Location = new System.Drawing.Point(19, 293);
            this.listeMaladies.Name = "listeMaladies";
            this.listeMaladies.Size = new System.Drawing.Size(99, 13);
            this.listeMaladies.TabIndex = 25;
            this.listeMaladies.Text = "Liste des maladies :";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(406, 93);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(92, 13);
            this.description.TabIndex = 28;
            this.description.Text = "Liste des rappels :";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(74, 40);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(35, 13);
            this.nom.TabIndex = 39;
            this.nom.Text = "Nom :";
            // 
            // listOfDiseases
            // 
            this.listOfDiseases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empty,
            this.nomMaladies,
            this.dateMaladies});
            this.listOfDiseases.ContextMenuStrip = this.contextMenuMaladie;
            this.listOfDiseases.Location = new System.Drawing.Point(22, 325);
            this.listOfDiseases.Name = "listOfDiseases";
            this.listOfDiseases.Size = new System.Drawing.Size(346, 173);
            this.listOfDiseases.TabIndex = 40;
            this.listOfDiseases.UseCompatibleStateImageBehavior = false;
            this.listOfDiseases.View = System.Windows.Forms.View.Details;
            // 
            // empty
            // 
            this.empty.Text = "";
            this.empty.Width = 0;
            // 
            // nomMaladies
            // 
            this.nomMaladies.Text = "Nom";
            this.nomMaladies.Width = 62;
            // 
            // dateMaladies
            // 
            this.dateMaladies.Text = "Date";
            // 
            // contextMenuMaladie
            // 
            this.contextMenuMaladie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.contextMenuMaladie.Name = "contextMenuMaladie";
            this.contextMenuMaladie.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // listReminders
            // 
            this.listReminders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Desc,
            this.columnHeader4});
            this.listReminders.ContextMenuStrip = this.contextMenuSoins;
            this.listReminders.Location = new System.Drawing.Point(409, 131);
            this.listReminders.Name = "listReminders";
            this.listReminders.Size = new System.Drawing.Size(502, 256);
            this.listReminders.TabIndex = 41;
            this.listReminders.UseCompatibleStateImageBehavior = false;
            this.listReminders.View = System.Windows.Forms.View.Details;
            // 
            // Desc
            // 
            this.Desc.DisplayIndex = 1;
            this.Desc.Text = "Description";
            this.Desc.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 150;
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
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // FicheAnimalInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 613);
            this.Controls.Add(this.listReminders);
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
            this.Controls.Add(this.genererFacture);
            this.Controls.Add(this.genererOrdonnance);
            this.Controls.Add(this.modifierAnimal);
            this.Controls.Add(this.ajouterRappel);
            this.Name = "FicheAnimalInterface";
            this.Text = "FicheAnimalInterface";
            this.contextMenuMaladie.ResumeLayout(false);
            this.contextMenuSoins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouterRappel;
        private System.Windows.Forms.Button modifierAnimal;
        private System.Windows.Forms.Button genererOrdonnance;
        private System.Windows.Forms.Button genererFacture;
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
        private System.Windows.Forms.ColumnHeader empty;
        private System.Windows.Forms.ColumnHeader nomMaladies;
        private System.Windows.Forms.ListView listReminders;
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
        private System.Windows.Forms.ColumnHeader dateMaladies;
    }
}