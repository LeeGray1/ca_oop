using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca
{
    class Student : Subject
    {
        private string name;
        //name of student
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private string dateofbirth;
        //name of the lecturer

        public string Dateofbirth
        {
            get
            {
                return this.dateofbirth;
            }
            set
            {
                this.dateofbirth = value;
            }
        }

        public void student()
        {
            Console.WriteLine($"Student name: {Name}");
            Console.WriteLine($"DAte of birth: {Dateofbirth}");
            Console.WriteLine($"Subjects");
           
           
        }

       
    }
}

