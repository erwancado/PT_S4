namespace Projet
{
    partial class ClientList
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
            this.clientContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.newClientButton = new System.Windows.Forms.Button();
            this.allClientList = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateNaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientContextMenu
            // 
            this.clientContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.clientContextMenu.Name = "clientContextMenu";
            this.clientContextMenu.Size = new System.Drawing.Size(130, 48);
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
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(188, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(38, 37);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 2;
            // 
            // newClientButton
            // 
            this.newClientButton.Location = new System.Drawing.Point(291, 34);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(75, 23);
            this.newClientButton.TabIndex = 3;
            this.newClientButton.Text = "nouveau";
            this.newClientButton.UseVisualStyleBackColor = true;
            this.newClientButton.Click += new System.EventHandler(this.newClientButton_Click);
            // 
            // allClientList
            // 
            this.allClientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNom,
            this.columnHeaderPrenom,
            this.columnHeaderDateNaissance,
            this.columnHeaderTel,
            this.columnHeaderEmail,
            this.columnHeaderRDV});
            this.allClientList.ContextMenuStrip = this.clientContextMenu;
            this.allClientList.Location = new System.Drawing.Point(38, 143);
            this.allClientList.Name = "allClientList";
            this.allClientList.Size = new System.Drawing.Size(703, 260);
            this.allClientList.TabIndex = 4;
            this.allClientList.UseCompatibleStateImageBehavior = false;
            this.allClientList.View = System.Windows.Forms.View.Details;
            this.allClientList.DoubleClick += new System.EventHandler(this.allClientList_DoubleClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderNom
            // 
            this.columnHeaderNom.Text = "Nom";
            // 
            // columnHeaderPrenom
            // 
            this.columnHeaderPrenom.Text = "Prénom";
            // 
            // columnHeaderDateNaissance
            // 
            this.columnHeaderDateNaissance.Text = "Date de naissance";
            this.columnHeaderDateNaissance.Width = 103;
            // 
            // columnHeaderTel
            // 
            this.columnHeaderTel.Text = "Téléphone";
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            // 
            // columnHeaderRDV
            // 
            this.columnHeaderRDV.Text = "Prochain rendez-vous";
            this.columnHeaderRDV.Width = 67;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allClientList);
            this.Controls.Add(this.newClientButton);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.searchButton);
            this.Name = "ClientList";
            this.Text = "ClientList";
            this.clientContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button newClientButton;
        private System.Windows.Forms.ContextMenuStrip clientContextMenu;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ListView allClientList;
        private System.Windows.Forms.ColumnHeader columnHeaderNom;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenom;
        private System.Windows.Forms.ColumnHeader columnHeaderDateNaissance;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderTel;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderRDV;
    }
}
