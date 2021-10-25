using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Student
    {
        public string name;
        public string lastName;
        public int age;
        public string id;

        public Student(string name, string lastName, int age, string id)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.id = id;
        }

        public Student(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.id = idGenerator();
        }

        public string printIt()
        {
            string result = "Name: " + this.name;
            result += "\nLast Name: " + this.lastName;
            result += "\nAge: " + this.age;
            result += "\nID: " + this.id;
            result += "\n++++++++++++++++++++++++++++++\n";
            return result;
        }

        private string idGenerator()
        {
            string result = name.Substring(0, 1);
            result += lastName.Substring(0, 1);
            result += yearOfbirthCalc();
            return result;

        }

        private string yearOfbirthCalc()
        {
            int yearofBirth = 2021 - age;
            return yearofBirth.ToString();
        }
    }
}
