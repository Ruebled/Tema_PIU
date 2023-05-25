using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objects;
using DataAdministration;

namespace Student_Form
{
    public partial class MainForm : Form
    {
        AdminStud adminStudenti;

        private Button btnAdauga;
        private Button btnDelete;

        private Label lblHeaderTitle;

        private Label lblHeaderNume;
        private Label lblHeaderPrenume;
        private Label lblHeaderId;

        int nrStudenti = 0;
        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsId;

        private CheckBox[] ckbDel;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 100;

        ArrayList studentiSelectati = new ArrayList();

        public MainForm()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            adminStudenti = new AdminStud(caleCompletaFisier);

            InitializeComponent();

            //proprietati
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.Text = "Lista Studenti";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ForeColor = Color.Black;
            this.MaximizeBox = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           AfiseazaStudenti();
        }

        public override void Refresh()
        {
            studentiSelectati.Clear();
            for(int i = 0; i < nrStudenti; i++)
            {
                ckbDel[i].Dispose();
                lblsNume[i].Dispose();
                lblsPrenume[i].Dispose();
                lblsId[i].Dispose();
            }

            AfiseazaStudenti();
        }

        private void AfiseazaStudenti()
        {
            //Adauga Title label
            lblHeaderTitle = new Label();
            lblHeaderTitle.Width = LATIME_CONTROL * 2;
            lblHeaderTitle.Height = DIMENSIUNE_PAS_Y;
            lblHeaderTitle.Text = "Lista Studenti";
            lblHeaderTitle.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            lblHeaderTitle.Left = (this.ClientSize.Width - lblHeaderTitle.Width) / 2;
            lblHeaderTitle.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(lblHeaderTitle);

            //Adauga label pentru numele studentilor
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = ((this.ClientSize.Width - lblHeaderNume.Width) / 2) - lblHeaderNume.Width + 15;
            lblHeaderNume.Top = DIMENSIUNE_PAS_Y * 3;
            this.Controls.Add(lblHeaderNume);

            //Adauga label pentru prenumele studentilor
            lblHeaderPrenume = new Label();
            lblHeaderPrenume.Width = LATIME_CONTROL;
            lblHeaderPrenume.Text = "Prenume";
            lblHeaderPrenume.Left = (this.ClientSize.Width - lblHeaderPrenume.Width) / 2 + 20;
            lblHeaderPrenume.Top = DIMENSIUNE_PAS_Y * 3;
            this.Controls.Add(lblHeaderPrenume);

            //Adauga label pentru ID studenti
            lblHeaderId = new Label();
            lblHeaderId.Width = LATIME_CONTROL;
            lblHeaderId.Text = "ID";
            lblHeaderId.Left = ((this.ClientSize.Width - lblHeaderId.Width) / 2) + lblHeaderId.Width + 40;
            lblHeaderId.Top = DIMENSIUNE_PAS_Y * 3;
            this.Controls.Add(lblHeaderId);

            //Get studenti from file
            ArrayList studenti = adminStudenti.GetStudenti();

            nrStudenti = studenti.Count;
            lblsNume = new Label[nrStudenti];
            lblsPrenume = new Label[nrStudenti];
            lblsId = new Label[nrStudenti];

            ckbDel = new CheckBox[nrStudenti];

            int i = 0;
            foreach(Student student in studenti)
            {
                // Add student afiliated checkbox
                ckbDel[i] = new CheckBox();
                ckbDel[i].Width = 20;
                ckbDel[i].Left = OFFSET_X - 2;
                ckbDel[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;
                ckbDel[i].Text = i.ToString();
                ckbDel[i].CheckedChanged += new System.EventHandler(this.CkbStudenti_CheckedChanged);
                this.Controls.Add(ckbDel[i]);

                //Add student nume
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = student.Nume;
                lblsNume[i].Left = ((this.ClientSize.Width - lblsNume[i].Width) / 2) - lblsNume[i].Width + 15; ;
                lblsNume[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;
                lblsNume[i].Click += (sender, e) => On_Click(sender, e, student);

                this.Controls.Add(lblsNume[i]);

                //Add student prenume
                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = student.Prenume;
                lblsPrenume[i].Left = ((this.ClientSize.Width - lblsPrenume[i].Width) / 2) + 20; ;
                lblsPrenume[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;
                lblsPrenume[i].Click += (sender, e) => On_Click(sender, e, student);
                this.Controls.Add(lblsPrenume[i]);

                lblsId[i] = new Label();
                lblsId[i].Width = LATIME_CONTROL;
                lblsId[i].Text = (student.IdStudent).ToString();
                lblsId[i].Left = ((this.ClientSize.Width - lblsId[i].Width) / 2) + lblsId[i].Width + 40; ;
                lblsId[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;
                lblsId[i].Click += (sender, e) => On_Click(sender, e, student);
                this.Controls.Add(lblsId[i]);
                
                i++;

            }



        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            AdaugaForm adaugaForm = new AdaugaForm(this);
            adaugaForm.ShowDialog();
            
        }

        private void On_Click(object sender, EventArgs e, Student studIndex)
        {
            StudentForm studentForm = new StudentForm(studIndex);
            studentForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Student s in studentiSelectati)
            {
                adminStudenti.DelStudent(s);
            }
            
            this.Refresh();
        }

        private void CkbStudenti_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;

            string studentSelected = checkBoxControl.Text;
            int studentIndex;
            bool result = Int32.TryParse(studentSelected, out studentIndex);

            if (!result) return;

            ArrayList studenti = adminStudenti.GetStudenti();

            if (checkBoxControl.Checked)
            {
                studentiSelectati.Add(studenti[studentIndex]);
            }
            else
            {
                studentiSelectati.Remove(studenti[studentIndex]);
            }
        }
    }
}
