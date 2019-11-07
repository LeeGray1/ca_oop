using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca
{
    class Subject
    {
        private string subjectname;
        //name of subject
        public string SUbjectName
        {
            get
            {
                return this.subjectname;
            }
            set
            {
                this.subjectname = value;
            }
        }

        private string lecturer;
        //name of the lecturer

        public string Lecturer
        {
            get
            {
                return this.lecturer;
            }
            set
            {
                this.lecturer = value;
            }
        }

        private int year;
        //what year the you are doing
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        public override string ToString()
        {
            return
                 string.Format($" {SUbjectName}" +
                 $"\n{Lecturer}" +
                 $"\n{Year}" +
                 $"\n");
        }
    }
}
