using System;
using System.Security.Cryptography.X509Certificates;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(5, 5); 
        }

        public static void ParamsSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

    }
}
