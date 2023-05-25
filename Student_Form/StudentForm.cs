using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objects;
using DataAdministration;
using Objects.Enumerari;

namespace Student_Form
{
    public partial class StudentForm : Form
    {

        public StudentForm(Student stud)
        {
            InitializeComponent();

            lblsNume.Text = stud.Nume;
            lblsPrenume.Text = stud.Prenume;
            lblsDNd.Text = stud.Birthday.day;
            lblsDNm.Text = stud.Birthday.month;
            lblsDNy.Text = stud.Birthday.year;

            string specialitate = string.Empty;


            lblsSpec.Text = stud.Specializare.ToString();
        }
    }
}
