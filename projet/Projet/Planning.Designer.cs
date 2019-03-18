namespace Projet
{
    partial class Planning
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
            this.rendezVousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pT4_S4P2C_E3DataSet = new Projet.PT4_S4P2C_E3DataSet();
            this.rendezVousTableAdapter = new Projet.PT4_S4P2C_E3DataSetTableAdapters.RendezVousTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pT4_S4P2C_E3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rendezVousBindingSource
            // 
            this.rendezVousBindingSource.DataMember = "RendezVous";
            this.rendezVousBindingSource.DataSource = this.pT4_S4P2C_E3DataSet;
            // 
            // pT4_S4P2C_E3DataSet
            // 
            this.pT4_S4P2C_E3DataSet.DataSetName = "PT4_S4P2C_E3DataSet";
            this.pT4_S4P2C_E3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rendezVousTableAdapter
            // 
            this.rendezVousTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Planning";
            this.Text = "Planning";
            this.Load += new System.EventHandler(this.Planning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pT4_S4P2C_E3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PT4_S4P2C_E3DataSet pT4_S4P2C_E3DataSet;
        private System.Windows.Forms.BindingSource rendezVousBindingSource;
        private PT4_S4P2C_E3DataSetTableAdapters.RendezVousTableAdapter rendezVousTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}