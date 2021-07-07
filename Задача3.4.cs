using System;
namespace Задача4
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = int.Parse(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine("{0}", a);
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("{0}", b);
            }
            else if(c>a && c>b)
            {
                Console.WriteLine("{0}", c);
            }
        }
    }
}
