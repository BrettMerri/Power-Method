using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int y = int.Parse(Console.ReadLine());

                long result = pow(x, y);

                Console.WriteLine("{0}^{1} = {2}", x, y, result);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static long pow(int x, int y)
        {
            long z = 1;
            for (long i=1; i<=y; i++)
            {
                z = z * x;
            }
            return z;
        }
    }
}
