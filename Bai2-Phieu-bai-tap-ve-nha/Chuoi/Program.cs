using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao chuoi thu 1: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
            Console.WriteLine("Nhap vao chuoi thu 2: ");
            string s1 = Console.ReadLine();
            for (int i = 0; i<s1.Length; i++)
            {
                if (s1[i] != ' ') Console.Write(s1[i]);
                else Console.WriteLine();
            }
            Console.WriteLine("Nhap vao chuoi thu 3: ");
            string s2 = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in s2.Replace(" ", string.Empty))
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] += 1;
                }
                else dict.Add(ch, 1);
            }
            foreach (char ch in dict.Keys)
            {
                Console.WriteLine($"{ch} xuat hien {dict[ch]} lan");
            }
            Console.ReadLine();
        }
    }
}
