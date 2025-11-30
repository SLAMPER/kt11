/*

using System;

namespace kt11
{
    class Program
    {
        public static void Swap<T>(ref T x, ref T y) where T : struct
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("before swap - int:");
            Console.WriteLine($"a = {a}, b = {b}");

            Swap(ref a, ref b);
            Console.WriteLine("after swap - int:");
            Console.WriteLine($"a = {a}, b = {b}");

            Console.WriteLine();

            double x = 3.14;
            double y = 2.71;
            Console.WriteLine("before swap - double:");
            Console.WriteLine($"x = {x}, y = {y}");

            Swap(ref x, ref y);
            Console.WriteLine("after swap - double:");
            Console.WriteLine($"x = {x}, y = {y}");

            Console.WriteLine();

            bool flag1 = true;
            bool flag2 = false;
            Console.WriteLine("before swap - bool:");
            Console.WriteLine($"flag1 = {flag1}, flag2 = {flag2}");

            Swap(ref flag1, ref flag2);
            Console.WriteLine("after swap - bool:");
            Console.WriteLine($"flag1 = {flag1}, flag2 = {flag2}");

            Console.ReadLine();
        }
    }
}

*/

/*

using System;

namespace kt11
{
    public class LinkedList<T> where T : class
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;

        public void Add(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Remove(T item)
        {
            if (head == null) return;

            if (head.Data == item)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == item)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public bool Contains(T item)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == item)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data is Person person)
                {
                    Console.Write(person.Name + " - ");
                }
                else if (current.Data is Book book)
                {
                    Console.Write(book.Title + " - ");
                }
                else
                {
                    Console.Write(current.Data + " - ");
                }
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    public class Book
    {
        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }
    }

    class Program
    {
        static void Main()
        {
            LinkedList<string> stringList = new LinkedList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("C#");

            Console.WriteLine("String list:");
            stringList.Print();
            Console.WriteLine("contains 'World': " + stringList.Contains("World"));

            stringList.Remove("World");
            Console.WriteLine("after removing 'World':");
            stringList.Print();

            Console.WriteLine();

            LinkedList<Person> personList = new LinkedList<Person>();
            personList.Add(new Person("John"));
            personList.Add(new Person("Alice"));
            personList.Add(new Person("Bob"));

            Console.WriteLine("person list ");
            personList.Print();

            Console.WriteLine();

            LinkedList<Book> bookList = new LinkedList<Book>();
            bookList.Add(new Book("Book1"));
            bookList.Add(new Book("Book2"));

            Console.WriteLine("book list ");
            bookList.Print();

            Console.ReadLine();
        }
    }
}

*/


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