using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doc_GhiFile
{
    class Program
    {
        static void Main(string[] args)
        {
			string luaChon = "";
			while (luaChon != "3")
			{
				Console.WriteLine("\nMAIN MENU:");
				Console.WriteLine("\n1. Nhap danh sach mat hang va ghi ra file ");
				Console.WriteLine("\n2. Doc va hien thi danh sach tu file");
				Console.WriteLine("\n3. Thoat");
				Console.Write("\nNhap vao lua chon cua ban: ");
				luaChon = Console.ReadLine();
				List<string> dsMatHang = new List<string>();
				switch (luaChon)
				{
					case "1":
						//Gọi phương thức đã viết để nhập tên hàng và ghi ra file
						Nhap_GhiFile(dsMatHang);
						break;
					case "2":
						//Gọi phương thức để đọc và hiển thị nội dung file ra màn hình
						Doc_HienThiFile();
						break;
					case "3":
						break;
					default:
						Console.Write("\nBan nhap sai lua chon! Nhan Enter chon lai.");
						Console.ReadLine();
						break;
				}
				Console.Clear();
			}
		}
		private static void Nhap_GhiFile(List<string> dsMatHang)
        {
			string tiepTuc = "";
			while (tiepTuc!="N")
            {
				Console.Write("\nNhap ten mat hang: ");
				dsMatHang.Add(Console.ReadLine());
				Console.Write("\nNhan N de ket thuc nhap!");
				tiepTuc = Console.ReadLine().ToUpper();
			}
			StreamWriter sw = new StreamWriter(@"E:\Hang.txt", true);
			foreach (string item in dsMatHang)
            {
				sw.WriteLine(item);
            }
			sw.Close();
		}

		private static void Doc_HienThiFile()
        {
			int wordCount = 0;
			StreamReader sr = new StreamReader(@"E:\TapTin.txt");
			while (sr.Peek() != -1)
            {
				string[] words = sr.ReadLine().Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

				wordCount += words.Length;
			}
			Console.WriteLine($"co {wordCount} tu trong file");
			sr.Close();
			Console.ReadLine();
        }
	}
}
