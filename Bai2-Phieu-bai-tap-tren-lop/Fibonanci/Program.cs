using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonanci
{
    class Program
    {
        static int Fibo(int m)
        {
            if (m == 0) return 0;
            else if (m == 1) return 1;
            else return Fibo(m - 1) + Fibo(m - 2);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write(Fibo(i) + " ");
            }
            Console.ReadLine();
        }
    }
}
