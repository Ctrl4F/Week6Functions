using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser();
            Sum();

        }

        public static void HelloUser()
        {
            Console.WriteLine("Enter your name");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}");

        }

        public static void Sum()
        {
            Console.WriteLine("what is your first name?");
            
            int Num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second name");
            int Num2 = Int32.Parse(Console.ReadLine());
             

        }
        


    }
}
