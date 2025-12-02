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