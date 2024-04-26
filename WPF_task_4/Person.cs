using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_task_4
{
    public class Database
    {
        public static List<Person> people = new List<Person>();

        //public static void Show_all_persons()
        //{
        //    for (int i = 0; i < people.Count; i++)
        //    {
        //        people.ToString();
        //    }
        //}
    }
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public bool Step_student { get; set; }
        public string City { get; set; }

        public Person()
        {
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.Sex = string.Empty;
            this.City = string.Empty;
            this.Step_student = false;
        }
        public Person(string name, string surname, string sex, bool step_student, string seher)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Step_student = step_student;
            this.City = seher;
        }
        public override string ToString()
        {
            string s;
            if (this.Step_student==true)
            {
                s = "Student";
            }
            else
            {
                s = "Not Student";
            }

            return $"{this.Name}-{this.Surname}-{this.City}-{this.Sex}-{s}";
        }
    }
}
