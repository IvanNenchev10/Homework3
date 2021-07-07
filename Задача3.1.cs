using System;
namespace Задача1
{
    class Program
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            if(number%2==0 && number!=0)
            {
                Console.WriteLine("Chisloto e chetno");
            }
            else if(number%2!=0 && number!=0)
            {
                Console.WriteLine("Chisloto e nechetno");
            }
            else
            {
                Console.WriteLine("Chisloto ne e nito chetno,nito nechetno");
            }
        }
    }
}
