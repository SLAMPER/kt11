using System;

namespace kt11
{
    public interface IPrintable<T>
    {
        void Print();
    }

    public class Student : IPrintable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public Student(string name, int age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void Print()
        {
            Console.WriteLine($"student Name={Name}, Age={Age}, Grade={Grade}");
        }
    }

    public struct Vector : IPrintable<Vector>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Print()
        {
            Console.WriteLine($"Vector: X={X}, Y={Y}, Z={Z}");
        }
    }

    class Program
    {
        public static void PrintItem<T>(T item) where T : IPrintable<T>
        {
            item.Print();
        }

        static void Main()
        {
            Student student1 = new Student("Max", 20, "A");
            Student student2 = new Student("Maxi", 22, "B");

            Console.WriteLine("students ");
            PrintItem(student1);
            PrintItem(student2);

            Console.WriteLine();

            Vector vector1 = new Vector(1.0, 2.0, 3.0);
            Vector vector2 = new Vector(4.5, 6.7, 8.9);

            Console.WriteLine("vectors ");
            PrintItem(vector1);
            PrintItem(vector2);

            Console.WriteLine();

            Console.WriteLine("calls ");
            student1.Print();
            vector1.Print();

            Console.ReadLine();
        }
    }
}