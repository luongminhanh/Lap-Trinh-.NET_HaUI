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
            string file = @"E:\matrix.txt";
            StreamReader reader = new StreamReader(file);
            int numRows = int.Parse(reader.ReadLine());
            int numColumns = int.Parse(reader.ReadLine());
            int[,] matrix = new int[numRows, numColumns];
            for (int i = 0; i < numRows; i++)
            {
                string[] rowValues = reader.ReadLine().Split(' ');
                for (int j = 0; j < numColumns; j++)
                    matrix[i, j] = int.Parse(rowValues[j]);
            }
            int tong = 0;
            for (int i = 0; i < numRows; i++)
                for (int j = 0; j < numColumns; j++)
                    tong += matrix[i, j];
            Console.WriteLine($"Tong cua cac phan tu trong mang la: {tong}");
            Console.ReadLine();
        }
    }
}
