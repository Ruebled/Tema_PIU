namespace Student_Form
{
    partial class AdaugaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblDataNasterii = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblSpec = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.rdbElectrotehnica = new System.Windows.Forms.RadioButton();
            this.rdbAutomatica = new System.Windows.Forms.RadioButton();
            this.rdbElectronica = new System.Windows.Forms.RadioButton();
            this.rdbCalculatoare = new System.Windows.Forms.RadioButton();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugare Student";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(13, 76);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(43, 16);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(12, 110);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(61, 16);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblDataNasterii
            // 
            this.lblDataNasterii.AutoSize = true;
            this.lblDataNasterii.Location = new System.Drawing.Point(12, 139);
            this.lblDataNasterii.Name = "lblDataNasterii";
            this.lblDataNasterii.Size = new System.Drawing.Size(82, 16);
            this.lblDataNasterii.TabIndex = 3;
            this.lblDataNasterii.Text = "Data nasterii";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(121, 76);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(254, 22);
            this.txtNume.TabIndex = 5;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(121, 103);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(254, 22);
            this.txtPrenume.TabIndex = 6;
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(15, 197);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(86, 16);
            this.lblSpec.TabIndex = 7;
            this.lblSpec.Text = "Specialitatea";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(121, 139);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(254, 22);
            this.dtp.TabIndex = 8;
            // 
            // rdbElectrotehnica
            // 
            this.rdbElectrotehnica.AutoSize = true;
            this.rdbElectrotehnica.Location = new System.Drawing.Point(121, 277);
            this.rdbElectrotehnica.Name = "rdbElectrotehnica";
            this.rdbElectrotehnica.Size = new System.Drawing.Size(113, 20);
            this.rdbElectrotehnica.TabIndex = 9;
            this.rdbElectrotehnica.TabStop = true;
            this.rdbElectrotehnica.Text = "Electrotehnica";
            this.rdbElectrotehnica.UseVisualStyleBackColor = true;
            // 
            // rdbAutomatica
            // 
            this.rdbAutomatica.AutoSize = true;
            this.rdbAutomatica.Location = new System.Drawing.Point(121, 224);
            this.rdbAutomatica.Name = "rdbAutomatica";
            this.rdbAutomatica.Size = new System.Drawing.Size(95, 20);
            this.rdbAutomatica.TabIndex = 10;
            this.rdbAutomatica.TabStop = true;
            this.rdbAutomatica.Text = "Automatica";
            this.rdbAutomatica.UseVisualStyleBackColor = true;
            // 
            // rdbElectronica
            // 
            this.rdbElectronica.AutoSize = true;
            this.rdbElectronica.Location = new System.Drawing.Point(121, 251);
            this.rdbElectronica.Name = "rdbElectronica";
            this.rdbElectronica.Size = new System.Drawing.Size(95, 20);
            this.rdbElectronica.TabIndex = 11;
            this.rdbElectronica.TabStop = true;
            this.rdbElectronica.Text = "Electronica";
            this.rdbElectronica.UseVisualStyleBackColor = true;
            // 
            // rdbCalculatoare
            // 
            this.rdbCalculatoare.AutoSize = true;
            this.rdbCalculatoare.Location = new System.Drawing.Point(120, 198);
            this.rdbCalculatoare.Name = "rdbCalculatoare";
            this.rdbCalculatoare.Size = new System.Drawing.Size(104, 20);
            this.rdbCalculatoare.TabIndex = 12;
            this.rdbCalculatoare.TabStop = true;
            this.rdbCalculatoare.Text = "Calculatoare";
            this.rdbCalculatoare.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(352, 337);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 13;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(15, 344);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 16);
            this.lblMesaj.TabIndex = 14;
            // 
            // AdaugaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.rdbCalculatoare);
            this.Controls.Add(this.rdbElectronica);
            this.Controls.Add(this.rdbAutomatica);
            this.Controls.Add(this.rdbElectrotehnica);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblDataNasterii);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdaugaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblDataNasterii;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.RadioButton rdbElectrotehnica;
        private System.Windows.Forms.RadioButton rdbAutomatica;
        private System.Windows.Forms.RadioButton rdbElectronica;
        private System.Windows.Forms.RadioButton rdbCalculatoare;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblMesaj;
    }
}