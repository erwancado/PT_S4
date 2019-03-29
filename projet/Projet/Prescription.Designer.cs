namespace Projet
{
    partial class Prescription
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
            this.panelFirstPage = new System.Windows.Forms.Panel();
            this.secondPagePanel = new System.Windows.Forms.Panel();
            this.productListBox = new System.Windows.Forms.ComboBox();
            this.addOrRemoveLineLabel = new System.Windows.Forms.Label();
            this.produitLabel = new System.Windows.Forms.Label();
            this.posologyInput = new System.Windows.Forms.RichTextBox();
            this.posologyLabel = new System.Windows.Forms.Label();
            this.removeLineButton = new System.Windows.Forms.Button();
            this.addLineButton = new System.Windows.Forms.Button();
            this.essaiLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.pdfExportButton = new System.Windows.Forms.Button();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthdayInput = new System.Windows.Forms.DateTimePicker();
            this.prenomInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.searchClientButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.ClientsAnimal = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelFirstPage.SuspendLayout();
            this.secondPagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFirstPage
            // 
            this.panelFirstPage.Controls.Add(this.secondPagePanel);
            this.panelFirstPage.Controls.Add(this.birthdayLabel);
            this.panelFirstPage.Controls.Add(this.prenomLabel);
            this.panelFirstPage.Controls.Add(this.nameLabel);
            this.panelFirstPage.Controls.Add(this.birthdayInput);
            this.panelFirstPage.Controls.Add(this.prenomInput);
            this.panelFirstPage.Controls.Add(this.nameInput);
            this.panelFirstPage.Controls.Add(this.searchClientButton);
            this.panelFirstPage.Controls.Add(this.nextButton);
            this.panelFirstPage.Controls.Add(this.ClientsAnimal);
            this.panelFirstPage.Controls.Add(this.listClient);
            this.panelFirstPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFirstPage.Location = new System.Drawing.Point(0, 0);
            this.panelFirstPage.Name = "panelFirstPage";
            this.panelFirstPage.Size = new System.Drawing.Size(1804, 911);
            this.panelFirstPage.TabIndex = 0;
            // 
            // secondPagePanel
            // 
            this.secondPagePanel.Controls.Add(this.productListBox);
            this.secondPagePanel.Controls.Add(this.addOrRemoveLineLabel);
            this.secondPagePanel.Controls.Add(this.produitLabel);
            this.secondPagePanel.Controls.Add(this.posologyInput);
            this.secondPagePanel.Controls.Add(this.posologyLabel);
            this.secondPagePanel.Controls.Add(this.removeLineButton);
            this.secondPagePanel.Controls.Add(this.addLineButton);
            this.secondPagePanel.Controls.Add(this.essaiLabel);
            this.secondPagePanel.Controls.Add(this.previousButton);
            this.secondPagePanel.Controls.Add(this.pdfExportButton);
            this.secondPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondPagePanel.Location = new System.Drawing.Point(0, 0);
            this.secondPagePanel.Name = "secondPagePanel";
            this.secondPagePanel.Size = new System.Drawing.Size(1804, 911);
            this.secondPagePanel.TabIndex = 11;
            this.secondPagePanel.Visible = false;
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.Location = new System.Drawing.Point(26, 132);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(245, 21);
            this.productListBox.TabIndex = 10;
            this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
            // 
            // addOrRemoveLineLabel
            // 
            this.addOrRemoveLineLabel.AutoSize = true;
            this.addOrRemoveLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrRemoveLineLabel.Location = new System.Drawing.Point(22, 62);
            this.addOrRemoveLineLabel.Name = "addOrRemoveLineLabel";
            this.addOrRemoveLineLabel.Size = new System.Drawing.Size(232, 20);
            this.addOrRemoveLineLabel.TabIndex = 9;
            this.addOrRemoveLineLabel.Text = "Ajouter ou supprimer une ligne :";
            // 
            // produitLabel
            // 
            this.produitLabel.AutoSize = true;
            this.produitLabel.Location = new System.Drawing.Point(23, 103);
            this.produitLabel.Name = "produitLabel";
            this.produitLabel.Size = new System.Drawing.Size(46, 13);
            this.produitLabel.TabIndex = 7;
            this.produitLabel.Text = "Produit :";
            // 
            // posologyInput
            // 
            this.posologyInput.Location = new System.Drawing.Point(26, 210);
            this.posologyInput.Name = "posologyInput";
            this.posologyInput.Size = new System.Drawing.Size(245, 140);
            this.posologyInput.TabIndex = 6;
            this.posologyInput.Text = "";
            // 
            // posologyLabel
            // 
            this.posologyLabel.AutoSize = true;
            this.posologyLabel.Location = new System.Drawing.Point(23, 182);
            this.posologyLabel.Name = "posologyLabel";
            this.posologyLabel.Size = new System.Drawing.Size(59, 13);
            this.posologyLabel.TabIndex = 5;
            this.posologyLabel.Text = "Posologie :";
            // 
            // removeLineButton
            // 
            this.removeLineButton.Location = new System.Drawing.Point(160, 367);
            this.removeLineButton.Name = "removeLineButton";
            this.removeLineButton.Size = new System.Drawing.Size(111, 23);
            this.removeLineButton.TabIndex = 4;
            this.removeLineButton.Text = "Supprimer la ligne";
            this.removeLineButton.UseVisualStyleBackColor = true;
            this.removeLineButton.Click += new System.EventHandler(this.removeLineButton_Click);
            // 
            // addLineButton
            // 
            this.addLineButton.Location = new System.Drawing.Point(26, 367);
            this.addLineButton.Name = "addLineButton";
            this.addLineButton.Size = new System.Drawing.Size(111, 23);
            this.addLineButton.TabIndex = 3;
            this.addLineButton.Text = "Ajouter la ligne";
            this.addLineButton.UseVisualStyleBackColor = true;
            this.addLineButton.Click += new System.EventHandler(this.addLineButton_Click);
            // 
            // essaiLabel
            // 
            this.essaiLabel.AutoSize = true;
            this.essaiLabel.Location = new System.Drawing.Point(490, 62);
            this.essaiLabel.Name = "essaiLabel";
            this.essaiLabel.Size = new System.Drawing.Size(35, 13);
            this.essaiLabel.TabIndex = 2;
            this.essaiLabel.Text = "label1";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(3, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "Retour";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // pdfExportButton
            // 
            this.pdfExportButton.Location = new System.Drawing.Point(81, 415);
            this.pdfExportButton.Name = "pdfExportButton";
            this.pdfExportButton.Size = new System.Drawing.Size(130, 23);
            this.pdfExportButton.TabIndex = 0;
            this.pdfExportButton.Text = "Valider l\'ordonnance";
            this.pdfExportButton.UseVisualStyleBackColor = true;
            this.pdfExportButton.Click += new System.EventHandler(this.pdfExportButton_Click);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(157, 82);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(102, 13);
            this.birthdayLabel.TabIndex = 10;
            this.birthdayLabel.Text = "Date de naissance :";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(233, 31);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(49, 13);
            this.prenomLabel.TabIndex = 9;
            this.prenomLabel.Text = "Prénom :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Nom :";
            // 
            // birthdayInput
            // 
            this.birthdayInput.Location = new System.Drawing.Point(98, 102);
            this.birthdayInput.Name = "birthdayInput";
            this.birthdayInput.Size = new System.Drawing.Size(200, 20);
            this.birthdayInput.TabIndex = 7;
            // 
            // prenomInput
            // 
            this.prenomInput.Location = new System.Drawing.Point(236, 47);
            this.prenomInput.Name = "prenomInput";
            this.prenomInput.Size = new System.Drawing.Size(100, 20);
            this.prenomInput.TabIndex = 6;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(46, 47);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 5;
            // 
            // searchClientButton
            // 
            this.searchClientButton.Location = new System.Drawing.Point(380, 103);
            this.searchClientButton.Name = "searchClientButton";
            this.searchClientButton.Size = new System.Drawing.Size(75, 23);
            this.searchClientButton.TabIndex = 3;
            this.searchClientButton.Text = "Rechercher";
            this.searchClientButton.UseVisualStyleBackColor = true;
            this.searchClientButton.Click += new System.EventHandler(this.searchClientButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(700, 415);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Suivant";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ClientsAnimal
            // 
            this.ClientsAnimal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ClientsAnimal.Location = new System.Drawing.Point(493, 82);
            this.ClientsAnimal.Name = "ClientsAnimal";
            this.ClientsAnimal.Size = new System.Drawing.Size(282, 244);
            this.ClientsAnimal.TabIndex = 1;
            this.ClientsAnimal.UseCompatibleStateImageBehavior = false;
            this.ClientsAnimal.View = System.Windows.Forms.View.Details;
            this.ClientsAnimal.SelectedIndexChanged += new System.EventHandler(this.ClientsAnimal_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nom";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date de naissance";
            // 
            // listClient
            // 
            this.listClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listClient.Location = new System.Drawing.Point(26, 132);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(429, 244);
            this.listClient.TabIndex = 0;
            this.listClient.UseCompatibleStateImageBehavior = false;
            this.listClient.View = System.Windows.Forms.View.Details;
            this.listClient.SelectedIndexChanged += new System.EventHandler(this.listClient_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenom";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date de naissance";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 911);
            this.Controls.Add(this.panelFirstPage);
            this.Location = new System.Drawing.Point(500, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prescription";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Prescription";
            this.panelFirstPage.ResumeLayout(false);
            this.panelFirstPage.PerformLayout();
            this.secondPagePanel.ResumeLayout(false);
            this.secondPagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFirstPage;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ListView ClientsAnimal;
        private System.Windows.Forms.ListView listClient;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button searchClientButton;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DateTimePicker birthdayInput;
        private System.Windows.Forms.TextBox prenomInput;
        private System.Windows.Forms.Panel secondPagePanel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button pdfExportButton;
        private System.Windows.Forms.Label essaiLabel;
        private System.Windows.Forms.RichTextBox posologyInput;
        private System.Windows.Forms.Label posologyLabel;
        private System.Windows.Forms.Button removeLineButton;
        private System.Windows.Forms.Button addLineButton;
        private System.Windows.Forms.Label addOrRemoveLineLabel;
        private System.Windows.Forms.Label produitLabel;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox productListBox;
    }
}