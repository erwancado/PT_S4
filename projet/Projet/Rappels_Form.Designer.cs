namespace Projet
{
    partial class Rappels_Form
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
            this.validateRappel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // validateRappel
            // 
            this.validateRappel.Location = new System.Drawing.Point(362, 261);
            this.validateRappel.Name = "validateRappel";
            this.validateRappel.Size = new System.Drawing.Size(188, 23);
            this.validateRappel.TabIndex = 29;
            this.validateRappel.Text = "Ajouter le rappel à l\'animal";
            this.validateRappel.UseVisualStyleBackColor = true;
            this.validateRappel.Click += new System.EventHandler(this.validateRappel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date rappel";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(471, 151);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(180, 20);
            this.datePicker.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Description  du rappel :";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(125, 123);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(241, 120);
            this.description.TabIndex = 22;
            this.description.Text = "";
            // 
            // Rappels_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validateRappel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description);
            this.Name = "Rappels_Form";
            this.Text = "Rappels_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validateRappel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox description;
    }
}