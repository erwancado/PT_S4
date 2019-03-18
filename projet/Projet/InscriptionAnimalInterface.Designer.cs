namespace Projet
{
    partial class InscriptionAnimalInterface
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
            this.nomAnimal = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.espece = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.Label();
            this.infosComplementaires = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.femelle = new System.Windows.Forms.RadioButton();
            this.inscription = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateDeNaissance = new System.Windows.Forms.Label();
            this.poids = new System.Windows.Forms.Label();
            this.retourFicheClient = new System.Windows.Forms.Button();
            this.ajoutEspece = new System.Windows.Forms.Button();
            this.ajoutRace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 0;
            // 
            // nomAnimal
            // 
            this.nomAnimal.AutoSize = true;
            this.nomAnimal.Location = new System.Drawing.Point(49, 83);
            this.nomAnimal.Name = "nomAnimal";
            this.nomAnimal.Size = new System.Drawing.Size(58, 13);
            this.nomAnimal.TabIndex = 1;
            this.nomAnimal.Text = "nomAnimal";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(598, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(174, 131);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // espece
            // 
            this.espece.AutoSize = true;
            this.espece.Location = new System.Drawing.Point(65, 122);
            this.espece.Name = "espece";
            this.espece.Size = new System.Drawing.Size(42, 13);
            this.espece.TabIndex = 3;
            this.espece.Text = "espece";
            // 
            // race
            // 
            this.race.AutoSize = true;
            this.race.Location = new System.Drawing.Point(72, 160);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(28, 13);
            this.race.TabIndex = 4;
            this.race.Text = "race";
            // 
            // sexe
            // 
            this.sexe.AutoSize = true;
            this.sexe.Location = new System.Drawing.Point(65, 203);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(29, 13);
            this.sexe.TabIndex = 5;
            this.sexe.Text = "sexe";
            // 
            // infosComplementaires
            // 
            this.infosComplementaires.AutoSize = true;
            this.infosComplementaires.Location = new System.Drawing.Point(631, 80);
            this.infosComplementaires.Name = "infosComplementaires";
            this.infosComplementaires.Size = new System.Drawing.Size(109, 13);
            this.infosComplementaires.TabIndex = 6;
            this.infosComplementaires.Text = "infosComplementaires";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(114, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(177, 203);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(47, 17);
            this.male.TabIndex = 13;
            this.male.TabStop = true;
            this.male.Text = "male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // femelle
            // 
            this.femelle.AutoSize = true;
            this.femelle.Location = new System.Drawing.Point(177, 233);
            this.femelle.Name = "femelle";
            this.femelle.Size = new System.Drawing.Size(58, 17);
            this.femelle.TabIndex = 14;
            this.femelle.TabStop = true;
            this.femelle.Text = "femelle";
            this.femelle.UseVisualStyleBackColor = true;
            // 
            // inscription
            // 
            this.inscription.Location = new System.Drawing.Point(345, 323);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(75, 23);
            this.inscription.TabIndex = 15;
            this.inscription.Text = "inscription";
            this.inscription.UseVisualStyleBackColor = true;
            this.inscription.Click += new System.EventHandler(this.inscription_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(436, 161);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // dateDeNaissance
            // 
            this.dateDeNaissance.AutoSize = true;
            this.dateDeNaissance.Location = new System.Drawing.Point(353, 58);
            this.dateDeNaissance.Name = "dateDeNaissance";
            this.dateDeNaissance.Size = new System.Drawing.Size(92, 13);
            this.dateDeNaissance.TabIndex = 18;
            this.dateDeNaissance.Text = "dateDeNaissance";
            // 
            // poids
            // 
            this.poids.AutoSize = true;
            this.poids.Location = new System.Drawing.Point(388, 168);
            this.poids.Name = "poids";
            this.poids.Size = new System.Drawing.Size(32, 13);
            this.poids.TabIndex = 19;
            this.poids.Text = "poids";
            // 
            // retourFicheClient
            // 
            this.retourFicheClient.Location = new System.Drawing.Point(111, 25);
            this.retourFicheClient.Name = "retourFicheClient";
            this.retourFicheClient.Size = new System.Drawing.Size(107, 23);
            this.retourFicheClient.TabIndex = 20;
            this.retourFicheClient.Text = "retourFicheClient";
            this.retourFicheClient.UseVisualStyleBackColor = true;
            this.retourFicheClient.Click += new System.EventHandler(this.retourFicheClient_Click);
            // 
            // ajoutEspece
            // 
            this.ajoutEspece.Location = new System.Drawing.Point(255, 122);
            this.ajoutEspece.Name = "ajoutEspece";
            this.ajoutEspece.Size = new System.Drawing.Size(74, 23);
            this.ajoutEspece.TabIndex = 22;
            this.ajoutEspece.Text = "ajoutEspece";
            this.ajoutEspece.UseVisualStyleBackColor = true;
            // 
            // ajoutRace
            // 
            this.ajoutRace.Location = new System.Drawing.Point(255, 163);
            this.ajoutRace.Name = "ajoutRace";
            this.ajoutRace.Size = new System.Drawing.Size(74, 23);
            this.ajoutRace.TabIndex = 23;
            this.ajoutRace.Text = "ajoutRace";
            this.ajoutRace.UseVisualStyleBackColor = true;
            // 
            // InscriptionAnimalInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ajoutRace);
            this.Controls.Add(this.ajoutEspece);
            this.Controls.Add(this.retourFicheClient);
            this.Controls.Add(this.poids);
            this.Controls.Add(this.dateDeNaissance);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.inscription);
            this.Controls.Add(this.femelle);
            this.Controls.Add(this.male);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.infosComplementaires);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.race);
            this.Controls.Add(this.espece);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nomAnimal);
            this.Controls.Add(this.textBox1);
            this.Name = "InscriptionAnimalInterface";
            this.Text = "InscriptionAnimalInterface";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nomAnimal;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label espece;
        private System.Windows.Forms.Label race;
        private System.Windows.Forms.Label sexe;
        private System.Windows.Forms.Label infosComplementaires;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton femelle;
        private System.Windows.Forms.Button inscription;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label dateDeNaissance;
        private System.Windows.Forms.Label poids;
        private System.Windows.Forms.Button retourFicheClient;
        private System.Windows.Forms.Button ajoutEspece;
        private System.Windows.Forms.Button ajoutRace;
    }
}