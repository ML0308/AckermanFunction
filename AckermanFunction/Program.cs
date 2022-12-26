using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AckermanFunc
{
    class Program
    {
        public static int AckermanFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return AckermanFunction(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AckermanFunction(m, n));
            Console.Read();
        }
    }
}
