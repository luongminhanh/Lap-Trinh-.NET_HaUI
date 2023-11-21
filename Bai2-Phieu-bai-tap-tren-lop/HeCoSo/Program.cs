using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeCoSo
{
    class Program
    {
        static void ConvertFromDecimalToBase(int N, int B)
        {
            string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder();

            while (N > 0)
            {
                int digit = N % B;
                result.Append(digits[digit]);
                N /= B;
            }

            char[] charArray = result.ToString().ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(new string(charArray));
        }
        static int ConvertFromBaseToDecimal(string input, int baseFrom)
        {
            string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int result = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int digitValue = digits.IndexOf(input[i]);
                result += digitValue * (int)Math.Pow(baseFrom, input.Length - 1 - i);
            }

            return result;
        }
        static int ConvertToDecimalFromBase(int N, int B)
        {
            int result = 0;
            int power = 0;

            while (N > 0)
            {
                int digit = N % 10;
                result += digit * (int)Math.Pow(B, power);
                N /= 10;
                power++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a, Nhap n va b: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Chuyen {n} tu he cơ so 10 sang he co so {b} duoc");
            ConvertFromDecimalToBase(n, b);
            Console.WriteLine("b, Nhap n va b: ");
            string n1 = Console.ReadLine();
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chuyen {n1} tu he cơ so {b1} sang he co so 10 duoc");
            Console.WriteLine(ConvertFromBaseToDecimal(n1, b1));
            Console.ReadLine();
        }
    }
}
