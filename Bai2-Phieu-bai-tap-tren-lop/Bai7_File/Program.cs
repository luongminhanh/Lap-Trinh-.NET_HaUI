using System;
using System.IO;

namespace Bai7_File
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo drive = new DriveInfo("C:/");
            Console.WriteLine($"Drive:  {drive.Name}");
            Console.WriteLine($"Drive type:  {drive.DriveType}");
            Console.WriteLine($"Drive:  {drive.TotalSize}");
            string sourceFilePath = @"C:\source\file.txt";
            string targetFilePath = @"E:\target\file.txt";
            /*
            try
            {
                // Sử dụng lớp file có sẵn
                File.Copy(sourceFilePath, targetFilePath, true);
                Console.WriteLine("Copy file thanh cong.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Co loi xay ra khi copy file: " + ex.Message);
            }
            Console.ReadLine();
            */
            try
            {
                // Sử dụng StreamReader và StreamWriter
                using (StreamReader reader = new StreamReader(sourceFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(targetFilePath))
                    {
                        writer.Write(reader.ReadToEnd());
                    }
                }
                Console.WriteLine("Copy file thanh cong.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Co loi xay ra khi copy file: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}

