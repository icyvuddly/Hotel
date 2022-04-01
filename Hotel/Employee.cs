

using System.Collections.Generic;

namespace Hotel
{
    public class Employee
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Experience { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }

        public Employee(string surName, string name, string patronymic, int experience, decimal salary)
        {
            SurName = surName;
            Name = name;
            Patronymic = patronymic;
            Experience = experience;
            Salary = salary;
        }

        public Employee(int id, string surName, string name, string patronymic, int experience, decimal salary)
        {
            Id = id;
            SurName = surName;
            Name = name;
            Patronymic = patronymic;
            Experience = experience;
            Salary = salary;
        }
        public Employee ()
        {

        }
    }
}
