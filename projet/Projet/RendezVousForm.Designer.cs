namespace Projet
{
    partial class RendezVousForm
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
            this.clientList = new System.Windows.Forms.ListBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.rdvView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clientList
            // 
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(201, 66);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(256, 121);
            this.clientList.TabIndex = 0;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(201, 220);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(188, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(201, 246);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(188, 20);
            this.timePicker.TabIndex = 2;
            this.timePicker.Value = new System.DateTime(2019, 3, 28, 16, 43, 42, 0);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(201, 294);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(256, 144);
            this.description.TabIndex = 3;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(79, 66);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(62, 20);
            this.labelClient.TabIndex = 5;
            this.labelClient.Text = "Client :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rendez-vous à cette date :";
            // 
            // validateButton
            // 
            this.validateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(606, 12);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(150, 47);
            this.validateButton.TabIndex = 9;
            this.validateButton.Text = "Ajouter";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // rdvView
            // 
            this.rdvView.FormattingEnabled = true;
            this.rdvView.Location = new System.Drawing.Point(550, 122);
            this.rdvView.Name = "rdvView";
            this.rdvView.Size = new System.Drawing.Size(238, 251);
            this.rdvView.TabIndex = 10;
            // 
            // RendezVousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdvView);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.description);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.clientList);
            this.Name = "RendezVousForm";
            this.Text = "RendezVousForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.ListBox rdvView;
    }
}