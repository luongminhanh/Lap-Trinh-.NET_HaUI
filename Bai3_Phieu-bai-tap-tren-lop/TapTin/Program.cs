using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TapTin
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"E:\TapTin.txt");
            StreamWriter writer = new StreamWriter(@"E:\TapTin2.txt");
            int count = 0;
       
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                    break;
                writer.WriteLine(line.ToUpper());
                string[] words = line.Split(new char[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in words)
                    count++;
            }    
            writer.WriteLine(count);
            reader.Close();
            writer.Close();
            Console.ReadLine();
        }
    }
}
