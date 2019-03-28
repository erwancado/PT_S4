namespace Projet
{
    partial class AnimauxInterface
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.filtrer = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.nomProprietaire = new System.Windows.Forms.Label();
            this.nomAnimal = new System.Windows.Forms.Label();
            this.espece = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Label();
            this.allAnimauxList = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();

            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(237, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 3;
            // 
            // filtrer
            // 
            this.filtrer.Location = new System.Drawing.Point(273, 304);
            this.filtrer.Name = "filtrer";
            this.filtrer.Size = new System.Drawing.Size(75, 23);
            this.filtrer.TabIndex = 0;
            this.filtrer.Text = "filtrer";
            this.filtrer.UseVisualStyleBackColor = true;
            this.filtrer.Click += new System.EventHandler(this.filtrer_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(506, 381);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 11;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(627, 381);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // nomProprietaire
            // 
            this.nomProprietaire.AutoSize = true;
            this.nomProprietaire.Location = new System.Drawing.Point(136, 58);
            this.nomProprietaire.Name = "nomProprietaire";
            this.nomProprietaire.Size = new System.Drawing.Size(80, 13);
            this.nomProprietaire.TabIndex = 14;
            this.nomProprietaire.Text = "nomProprietaire";
            // 
            // nomAnimal
            // 
            this.nomAnimal.AutoSize = true;
            this.nomAnimal.Location = new System.Drawing.Point(136, 103);
            this.nomAnimal.Name = "nomAnimal";
            this.nomAnimal.Size = new System.Drawing.Size(58, 13);
            this.nomAnimal.TabIndex = 15;
            this.nomAnimal.Text = "nomAnimal";
            // 
            // espece
            // 
            this.espece.AutoSize = true;
            this.espece.Location = new System.Drawing.Point(136, 137);
            this.espece.Name = "espece";
            this.espece.Size = new System.Drawing.Size(42, 13);
            this.espece.TabIndex = 16;
            this.espece.Text = "espece";
            // 
            // race
            // 
            this.race.AutoSize = true;
            this.race.Location = new System.Drawing.Point(303, 137);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(28, 13);
            this.race.TabIndex = 17;
            this.race.Text = "race";
            // 
            // allAnimauxList
            // 
            this.allAnimauxList.Location = new System.Drawing.Point(414, 58);
            this.allAnimauxList.Name = "allAnimauxList";
            this.allAnimauxList.Size = new System.Drawing.Size(374, 296);
            this.allAnimauxList.TabIndex = 19;
            this.allAnimauxList.UseCompatibleStateImageBehavior = false;
            this.allAnimauxList.DoubleClick += new System.EventHandler(this.allAnimauxList_DoubleClick);

            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(252, 153);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // AnimauxInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);

            this.Controls.Add(this.allAnimauxList);
            this.Controls.Add(this.race);
            this.Controls.Add(this.espece);
            this.Controls.Add(this.nomAnimal);
            this.Controls.Add(this.nomProprietaire);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.filtrer);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Name = "AnimauxInterface";
            this.Text = "AnimauxInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button filtrer;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label nomProprietaire;
        private System.Windows.Forms.Label nomAnimal;
        private System.Windows.Forms.Label espece;
        private System.Windows.Forms.Label race;
        private System.Windows.Forms.ListView allAnimauxList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;

    }
}