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

            Console.WriteLine("string list ");
            stringList.Print();
            Console.WriteLine("contains 'World' " + stringList.Contains("World"));

            stringList.Remove("world");
            Console.WriteLine("after removing 'World':");
            stringList.Print();

            Console.WriteLine();

            LinkedList<Person> personList = new LinkedList<Person>();
            personList.Add(new Person("Max"));
            personList.Add(new Person("Maxi"));
            personList.Add(new Person("Maxo"));

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