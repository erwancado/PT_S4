namespace Projet
{
    partial class ClientForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.naissanceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.manRadioButton = new System.Windows.Forms.RadioButton();
            this.womanRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(88, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(88, 82);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "prenom :";
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(88, 195);
            this.adressTextBox.Multiline = true;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(201, 106);
            this.adressTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "naissance :";
            // 
            // naissanceDatePicker
            // 
            this.naissanceDatePicker.Location = new System.Drawing.Point(89, 143);
            this.naissanceDatePicker.Name = "naissanceDatePicker";
            this.naissanceDatePicker.Size = new System.Drawing.Size(200, 20);
            this.naissanceDatePicker.TabIndex = 7;
            this.naissanceDatePicker.ValueChanged += new System.EventHandler(this.naissanceDatePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexe :";
            // 
            // manRadioButton
            // 
            this.manRadioButton.AutoSize = true;
            this.manRadioButton.Checked = true;
            this.manRadioButton.Location = new System.Drawing.Point(103, 116);
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.Size = new System.Drawing.Size(61, 17);
            this.manRadioButton.TabIndex = 9;
            this.manRadioButton.TabStop = true;
            this.manRadioButton.Text = "Homme";
            this.manRadioButton.UseVisualStyleBackColor = true;
            this.manRadioButton.CheckedChanged += new System.EventHandler(this.manRadioButton_CheckedChanged);
            // 
            // womanRadioButton
            // 
            this.womanRadioButton.AutoSize = true;
            this.womanRadioButton.Location = new System.Drawing.Point(214, 116);
            this.womanRadioButton.Name = "womanRadioButton";
            this.womanRadioButton.Size = new System.Drawing.Size(59, 17);
            this.womanRadioButton.TabIndex = 10;
            this.womanRadioButton.Text = "Femme";
            this.womanRadioButton.UseVisualStyleBackColor = true;
            this.womanRadioButton.CheckedChanged += new System.EventHandler(this.womanRadioButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "tel :";
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(88, 331);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 20);
            this.telTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "email :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(88, 392);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(588, 169);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 15;
            this.insertButton.Text = "Inscription";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.womanRadioButton);
            this.Controls.Add(this.manRadioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.naissanceDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker naissanceDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton manRadioButton;
        private System.Windows.Forms.RadioButton womanRadioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button insertButton;
    }
}