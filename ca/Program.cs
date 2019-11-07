using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s1 = new Subject();
            s1.SUbjectName = "Object orientated programming";
            s1.Lecturer = "Keith";
            s1.Year = 2;

            Subject s2 = new Subject();
            s2.SUbjectName = "Web design and development";
            s2.Lecturer = "Colm";
            s2.Year = 2;

            Subject s3 = new Subject();
            s3.SUbjectName = "Requirments engineering";
            s3.Lecturer = "Thereses";
            s3.Year = 2;

            Subject s4 = new Subject();
            s4.SUbjectName = "Client side scripting";
            s4.Lecturer = "Colm";
            s4.Year = 2;

            Student st1 = new Student();
            st1.Name = "Lee";
            st1.Dateofbirth = "17/07/00";

            Student st2 = new Student();
            st2.Name = "James";
            st2.Dateofbirth = "15/05/99";


            Console.WriteLine($"Name: {st1.Name}\nDate of birth: {st1.Dateofbirth}");
            Console.WriteLine($"\n{s1.SUbjectName} {s1.Lecturer} {s1.Year}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n{s2.SUbjectName} {s2.Lecturer} {s2.Year}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n{s3.SUbjectName} {s3.Lecturer} {s3.Year}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n{s4.SUbjectName} {s4.Lecturer} {s4.Year}");
            Console.WriteLine("\n");


            Console.WriteLine($"Name: {st2.Name}\nDate of birth: {st2.Dateofbirth}");
            Console.WriteLine($"\n{s1.SUbjectName} {s1.Lecturer} {s1.Year}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n{s2.SUbjectName} {s2.Lecturer} {s2.Year}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n{s3.SUbjectName} {s3.Lecturer} {s3.Year}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n{s4.SUbjectName} {s4.Lecturer} {s4.Year}");
            Console.WriteLine("\n");
        }
            
    }
}
