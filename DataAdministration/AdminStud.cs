using Objects;
using System.Collections;
using System.IO;

namespace DataAdministration
{
    public class AdminStud
    {
        private const int ID_PRIMUL_STUDENT = 1;
        private const int INCREMENT = 1;

        private string numeFisier;

        public AdminStud(string numeFisier)
        {
            this.numeFisier = numeFisier;

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddStudent(Student student)
        {
            student.IdStudent = GetId();

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(student.ConversieLaSir_Fisier());
            }
        }

        public void DelStudent(Student student)
        {
            ArrayList studenti = new ArrayList();

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student_cit = new Student(linieFisier);
                    
                    if(student != student_cit)
                    {
                        studenti.Add(student_cit);
                    }
                }
            }
            Stream streamFisierText = File.Open(numeFisier, FileMode.Truncate);
            streamFisierText.Close();
            foreach (Student student_temp in studenti)
            {
                this.AddStudent(student_temp);
            }
            
        }

        public ArrayList GetStudenti()
        {
            ArrayList studenti = new ArrayList();

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student = new Student(linieFisier);
                    studenti.Add(student);
                }
            }
            return studenti;
        }

        private int GetId()
        {
            int IdStudent = ID_PRIMUL_STUDENT;

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student = new Student(linieFisier);
                    IdStudent = student.IdStudent + INCREMENT;
                }
            }
            return IdStudent;
        }
    }
}