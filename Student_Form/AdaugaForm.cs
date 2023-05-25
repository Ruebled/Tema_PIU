using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdministration;
using Objects;
using Objects.Enumerari;

namespace Student_Form
{
    public partial class AdaugaForm : Form
    {
        AdminStud adminStudenti;
        MainForm local;

        public AdaugaForm(MainForm form)
        {
            local = form;

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            adminStudenti = new AdminStud(caleCompletaFisier);

            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblNume.ForeColor = Color.Red;
                lblPrenume.ForeColor = Color.Red;

                return;
            }

            Student s = new Student();
            s.Nume = txtNume.Text;
            s.Prenume = txtPrenume.Text;

            // Extract date
            s.Birthday = new Objects.Structuri.birthDay() {
                day = dtp.Value.Date.Day.ToString(),
                month = dtp.Value.Date.Month.ToString(),
                year = dtp.Value.Date.Year.ToString()
            };
            
            
            ProgramStudiu specSelectata = GetProgramStudiuSelectat();

            adminStudenti.AddStudent(s);

            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblMesaj.ForeColor = Color.Green;
            lblMesaj.Text = "Studentul a fost adaugat";

            //Clear inputtextbox
            txtNume.Text = "";
            txtPrenume.Text = "";

            rdbAutomatica.Checked = false;
            rdbCalculatoare.Checked = false;
            rdbElectronica.Checked = false;
            rdbElectrotehnica.Checked = false;

            local.Refresh();
        }

        private bool DateIntrareValide()
        {
            if (txtNume.Text.Length < 5 )
            {
                lblMesaj.ForeColor = Color.Red;
                lblMesaj.Text = "Nume Scurt";
                return false;
            }

            if(txtPrenume.Text.Length < 5)
            {
                lblMesaj.ForeColor = Color.Red;
                lblMesaj.Text = "Prenume Scurt";
                return false;
            }
            return true;
            
        }

        private ProgramStudiu GetProgramStudiuSelectat()
        {
            if (rdbAutomatica.Checked)
            {
                return ProgramStudiu.Automatica;
            }
            if (rdbCalculatoare.Checked)
            {
                return ProgramStudiu.Calculatoare;
            }
            if (rdbElectronica.Checked)
            {
                return ProgramStudiu.Electronica;
            }
            if (rdbElectrotehnica.Checked)
            {
                return ProgramStudiu.Electrotehnica;
            }

            return ProgramStudiu.Calculatoare;
        }
    }
}
