using Objects.Structuri;
using Objects.Enumerari;

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

            IdStudent = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];

            setBirthDay(dateFisier[BIRTHDAY], SEPARATOR_BIRTHDAY);

            Specializare = (ProgramStudiu)Enum.Parse(typeof(ProgramStudiu), dateFisier[SPECIALIZARE]);
        }

        public string ConversieLaSir_Fisier()
        {
            string birthDay = string.Empty;

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

        public void setBirthDay(string line, char SEPARATOR)
        {
            string[] vectorBirthDay = line.Split(SEPARATOR);

            birthDay temp = new birthDay();

            temp.day = vectorBirthDay[0];
            temp.month = vectorBirthDay[1];
            temp.year = vectorBirthDay[2];

            Birthday = temp;
        }
    }
}