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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.filtrer = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.nomProprietaire = new System.Windows.Forms.Label();
            this.nomAnimal = new System.Windows.Forms.Label();
            this.espece = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.allAnimauxList = new System.Windows.Forms.ListView();
            this.add = new System.Windows.Forms.Button();
            this.sexe = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(237, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(237, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
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
            this.edit.Location = new System.Drawing.Point(495, 415);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 11;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(576, 415);
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
            this.espece.Location = new System.Drawing.Point(143, 142);
            this.espece.Name = "espece";
            this.espece.Size = new System.Drawing.Size(42, 13);
            this.espece.TabIndex = 16;
            this.espece.Text = "espece";
            // 
            // race
            // 
            this.race.AutoSize = true;
            this.race.Location = new System.Drawing.Point(150, 182);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(28, 13);
            this.race.TabIndex = 17;
            this.race.Text = "race";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(136, 260);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(28, 13);
            this.date.TabIndex = 18;
            this.date.Text = "date";
            // 
            // allAnimauxList
            // 
            this.allAnimauxList.Location = new System.Drawing.Point(414, 58);
            this.allAnimauxList.Name = "allAnimauxList";
            this.allAnimauxList.Size = new System.Drawing.Size(374, 296);
            this.allAnimauxList.TabIndex = 19;
            this.allAnimauxList.UseCompatibleStateImageBehavior = false;
            this.allAnimauxList.DoubleClick += new System.EventHandler(this.allAnimauxList_DoubleClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(414, 415);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 20;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sexe
            // 
            this.sexe.AutoSize = true;
            this.sexe.Location = new System.Drawing.Point(150, 218);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(29, 13);
            this.sexe.TabIndex = 21;
            this.sexe.Text = "sexe";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(237, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 20);
            this.textBox5.TabIndex = 22;
            // 
            // AnimauxInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.add);
            this.Controls.Add(this.allAnimauxList);
            this.Controls.Add(this.date);
            this.Controls.Add(this.race);
            this.Controls.Add(this.espece);
            this.Controls.Add(this.nomAnimal);
            this.Controls.Add(this.nomProprietaire);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.filtrer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AnimauxInterface";
            this.Text = "AnimauxInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button filtrer;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label nomProprietaire;
        private System.Windows.Forms.Label nomAnimal;
        private System.Windows.Forms.Label espece;
        private System.Windows.Forms.Label race;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.ListView allAnimauxList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label sexe;
        private System.Windows.Forms.TextBox textBox5;
    }
}