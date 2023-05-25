namespace Student_Form
{
    partial class StudentForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblDN = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblsNume = new System.Windows.Forms.Label();
            this.lblsPrenume = new System.Windows.Forms.Label();
            this.lblsDNd = new System.Windows.Forms.Label();
            this.lblsSpec = new System.Windows.Forms.Label();
            this.lblsDNm = new System.Windows.Forms.Label();
            this.lblsDNy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(140, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Info Student";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(13, 78);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(43, 16);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(13, 116);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(61, 16);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.Location = new System.Drawing.Point(13, 151);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(85, 16);
            this.lblDN.TabIndex = 3;
            this.lblDN.Text = "Data Nasterii";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(13, 189);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(78, 16);
            this.lblSpec.TabIndex = 4;
            this.lblSpec.Text = "Specialitate";
            // 
            // lblsNume
            // 
            this.lblsNume.AutoSize = true;
            this.lblsNume.Location = new System.Drawing.Point(175, 77);
            this.lblsNume.Name = "lblsNume";
            this.lblsNume.Size = new System.Drawing.Size(44, 16);
            this.lblsNume.TabIndex = 5;
            this.lblsNume.Text = "label1";
            // 
            // lblsPrenume
            // 
            this.lblsPrenume.AutoSize = true;
            this.lblsPrenume.Location = new System.Drawing.Point(175, 115);
            this.lblsPrenume.Name = "lblsPrenume";
            this.lblsPrenume.Size = new System.Drawing.Size(44, 16);
            this.lblsPrenume.TabIndex = 6;
            this.lblsPrenume.Text = "label2";
            // 
            // lblsDNd
            // 
            this.lblsDNd.AutoSize = true;
            this.lblsDNd.Location = new System.Drawing.Point(175, 151);
            this.lblsDNd.Name = "lblsDNd";
            this.lblsDNd.Size = new System.Drawing.Size(44, 16);
            this.lblsDNd.TabIndex = 7;
            this.lblsDNd.Text = "label3";
            // 
            // lblsSpec
            // 
            this.lblsSpec.AutoSize = true;
            this.lblsSpec.Location = new System.Drawing.Point(175, 189);
            this.lblsSpec.Name = "lblsSpec";
            this.lblsSpec.Size = new System.Drawing.Size(44, 16);
            this.lblsSpec.TabIndex = 8;
            this.lblsSpec.Text = "label4";
            // 
            // lblsDNm
            // 
            this.lblsDNm.AutoSize = true;
            this.lblsDNm.Location = new System.Drawing.Point(225, 151);
            this.lblsDNm.Name = "lblsDNm";
            this.lblsDNm.Size = new System.Drawing.Size(44, 16);
            this.lblsDNm.TabIndex = 9;
            this.lblsDNm.Text = "label5";
            // 
            // lblsDNy
            // 
            this.lblsDNy.AutoSize = true;
            this.lblsDNy.Location = new System.Drawing.Point(275, 151);
            this.lblsDNy.Name = "lblsDNy";
            this.lblsDNy.Size = new System.Drawing.Size(44, 16);
            this.lblsDNy.TabIndex = 10;
            this.lblsDNy.Text = "label6";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 337);
            this.Controls.Add(this.lblsDNy);
            this.Controls.Add(this.lblsDNm);
            this.Controls.Add(this.lblsSpec);
            this.Controls.Add(this.lblsDNd);
            this.Controls.Add(this.lblsPrenume);
            this.Controls.Add(this.lblsNume);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblDN);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.ShowIcon = false;
            this.Text = "Info Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.Label lblsNume;
        private System.Windows.Forms.Label lblsPrenume;
        private System.Windows.Forms.Label lblsDNd;
        private System.Windows.Forms.Label lblsSpec;
        private System.Windows.Forms.Label lblsDNm;
        private System.Windows.Forms.Label lblsDNy;
    }
}