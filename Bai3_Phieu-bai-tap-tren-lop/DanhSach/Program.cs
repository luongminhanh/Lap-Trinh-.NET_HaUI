using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ds = new List<double>(5);
            for (int i = 0; i < 5; i++)
                ds.Add(Convert.ToDouble(Console.ReadLine()));
            foreach (double item in ds) 
                Console.Write(item.ToString() + " ");
            ds.Sort();
            foreach (double item in ds)
                if (item < 0) ds.Remove(item);
            foreach (double item in ds)
                Console.Write(item.ToString() + " ");
            Console.WriteLine("Nhap x: ");
            double x = double.Parse(Console.ReadLine());
            int i1 = 0;
            while (x > ds[i1]) i1++;
            ds.Insert(i1, x);
            foreach (double item in ds)
                Console.Write(item.ToString() + " ");
            Console.ReadLine();
        }
    }
}
