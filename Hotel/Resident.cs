

using System.Collections.Generic;

namespace Hotel
{
    public class Resident
    {
        public int Id { get; set; }
        public string CodePassport { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Number { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }

        public Resident(int id, string codePassport, string surName, string name, string patronymic, int age, string gender, string number)
        {
            Id = id;
            CodePassport = codePassport;
            SurName = surName;
            Name = name;
            Patronymic = patronymic;
            Age = age;
            Gender = gender;
            Number = number;
        }

        public Resident(string codePassport, string surName, string name, string patronymic, int age, string gender, string number)
        {
            CodePassport = codePassport;
            SurName = surName;
            Name = name;
            Patronymic = patronymic;
            Age = age;
            Gender = gender;
            Number = number;
        }
        public Resident ()
        {

        }
    }
}
