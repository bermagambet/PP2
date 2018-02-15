using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle Radius = new Circle(int.Parse(Console.ReadLine()));
            Console.WriteLine(Radius.FindCircumference() + " and " + Radius.findDiameter());
            Console.ReadKey();

            List<Student> students = new List<Student>();
            string s = Console.ReadLine();
            string[] names = s.Split(' ');
            for (int i = 0; i < names.Length; i++ )
            {

                Student student = new Student(names[i], names[i+1]);
                student.gpa = double.Parse(names[i+2]);
                students.Add(student);
                i += 2;
            }
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " " + student.Surname + " " + student.gpa);
            }
            Console.ReadKey();
        }
    }
}
