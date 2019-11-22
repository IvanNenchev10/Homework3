using System;
namespace Задача6
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            bool result = false;
            string message;
            Console.WriteLine("Enter first side of the triangle:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side of the triangle:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third side of the triangle:");
            c = int.Parse(Console.ReadLine());
            if((a+b)>c && (a+c)>b && (b+c)>a)
            {
                result = true;
            }
            message = result == true ? "Stranite obrazuvat triugulnik" : "Stranite ne obrazuvat triugulnik";
            Console.WriteLine("{0}",message);
            
        }
    }
}
