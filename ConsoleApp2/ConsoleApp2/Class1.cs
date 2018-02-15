        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public string Name, Surname;
        public double gpa;

        public Student(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public override string ToString()
        {
            return this.Name + " " + Surname + " " + gpa;
        }

    }
    class Rectangle
    {
        public double width, height;
        public Rectangle (double width, double height)
        {
            this.width = width;
            this.width = width;
        }
        public static double findArea(double width, double height)
        {
            return width * height;
        }
        public static double findPerimeter(double width, double height)
        {
            return ((2 * width) + (2 * height));
        }
    }
    class Circle
    {
        double radius;
        public Circle (double radius)
        {
            this.radius = radius;
        }
        public double FindCircumference()
        {
            return this.radius* 2 * Math.PI;
        }
        public double findDiameter()
        {
            return this.radius * 2;
        }
        public double findArea()
        {
            return this.radius * radius * Math.PI;
        }
    }

}
