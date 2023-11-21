using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoiXung
{
    class Program
    {
        private static int DoiXung(string s)
        {
            int n = s.Length;
                for (int i = 0; i <= n/2; i++)
                    if (s[i] != s[n-i-1])
                        return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            if (DoiXung(s)==1) Console.WriteLine($"{s} la xau doi xung");
            else Console.WriteLine($"{s} khong la xau doi xung");
            Console.ReadLine();
        }
    }
}
