using System;
namespace Задача3
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("a is bigger than b");
            }
            else if(b>a)
            {
                Console.WriteLine("b is bigger than a");
            }
            else
            {
                Console.WriteLine("a is equal to b");
            }
        }
    }
}
