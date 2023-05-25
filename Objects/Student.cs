using Objects.Structuri;
using Objects.Enumerari;
using System;

namespace Objects
{
    public class Student
    {
        private const char SEPARATOR_FISIER = ';';
        private const char SEPARATOR_BIRTHDAY = ':';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int BIRTHDAY = 3;
        private const int SPECIALIZARE = 4;

        public int IdStudent { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public birthDay Birthday { get; set; }
        public ProgramStudiu Specializare { get; set; }

        public Student()
        {
            Nume = Prenume = string.Empty;
        }

        public Student(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_FISIER);

            IdStudent = System.Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];

            SetBirthDay(dateFisier[BIRTHDAY], SEPARATOR_BIRTHDAY);

            Specializare = (ProgramStudiu)Enum.Parse(typeof(ProgramStudiu), dateFisier[SPECIALIZARE]);
        }

        public static bool operator ==(Student a, Student b)
        {
            if (a.Nume != b.Nume) return false;
            if (a.Prenume != b.Prenume) return false;
            //if (a.Birthday != b.Birthday) return false;
            //if (a.Specializare != b.Specializare) return false;
            return true;

        }
        public static bool operator !=(Student a, Student b)
        {
            if (a.Nume == b.Nume) return false;
            if (a.Prenume == b.Prenume) return false;
            //if (a.Birthday != b.Birthday) return false;
            //if (a.Specializare == b.Specializare) return false;
            return true;
        }

        public string ConversieLaSir_Fisier()
        {
            //string birthDay = string.Empty;

            string obiectStudentFisier = string.Format("{2}{0}{3}{0}{4}{0}{5}{1}{6}{1}{7}{0}{8}",
                SEPARATOR_FISIER,
                SEPARATOR_BIRTHDAY,
                IdStudent.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Prenume ?? " NECUNOSCUT "),
                Birthday.day,
                Birthday.month,
                Birthday.year,
                Specializare
                );
            return obiectStudentFisier;

        }

        public void SetBirthDay(string line, char SEPARATOR)
        {
            string[] vectorBirthDay = line.Split(SEPARATOR);

            Birthday = new birthDay()
            {
                day = vectorBirthDay[0],
                month = vectorBirthDay[1],
                year = vectorBirthDay[2]
            };
        }
    }
}