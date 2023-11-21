using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaiTongHop
{
    class Program
    {

        static List<SinhVien> listSV = new List<SinhVien>();
        public struct SinhVien
        {
            public int id;
            public string Ten;
            public string GioiTinh;
            public int Tuoi;
            public double DiemToan;
            public double DiemLy;
            public double DiemHoa;
            public double DiemTB;
            public string HocLuc;

            public SinhVien(int id, string Ten, string GioiTinh, int Tuoi, double DiemToan, double DiemLy, double DiemHoa)
            {
                this.id = id;
                this.Ten = Ten;
                this.GioiTinh = GioiTinh;
                this.Tuoi = Tuoi;
                this.DiemToan = DiemToan;
                this.DiemLy = DiemLy;
                this.DiemHoa = DiemHoa;
                this.DiemTB = (DiemToan + DiemLy + DiemHoa) / 3;
                this.HocLuc = XepLoai(DiemTB);
            }

            public static string XepLoai(double diemTB)
            {
                if (diemTB >= 8)
                {
                    return "Giỏi";
                }
                else if (diemTB >= 6.5)
                {
                    return "Khá";
                }
                else if (diemTB >= 5)
                {
                    return "Trung Bình";
                }
                else
                {
                    return "Yếu";
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            LoadStudentsFromFile();

            while (true)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Thêm sinh viên.");
                Console.WriteLine("2. Cập nhật thông tin sinh viên bởi ID.");
                Console.WriteLine("3. Xóa sinh viên bởi ID.");
                Console.WriteLine("4. Tìm kiếm sinh viên theo tên.");
                Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung bình.");
                Console.WriteLine("6. Sắp xếp sinh viên theo tên.");
                Console.WriteLine("7. Hiển thị danh sách sinh viên.");
                Console.WriteLine("8. Ghi danh sách sinh viên vào file \"student.txt\".");
                Console.WriteLine("0. Thoát chương trình.");
                Console.Write("Vui lòng chọn chức năng (0-8): ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        UpdateStudent();
                        break;
                    case "3":
                        DeleteStudent();
                        break;
                    case "4":
                        SearchStudentsByName();
                        break;
                    case "5":
                        SortByAverageScore();
                        break;
                    case "6":
                        SortByName();
                        break;
                    case "7":
                        DisplayStudents();
                        break;
                    case "8":
                        GhiVaoFile();
                        break;
                    case "0":
                        Console.WriteLine("Chương trình đã kết thúc.");
                        return;
                    default:
                        Console.WriteLine("Vui lòng chọn chức năng hợp lệ.");
                        break;
                }
            }
        }
        public static void LoadStudentsFromFile()
        {
            try
            {
                StreamReader reader = new StreamReader(@"E:\student.txt");
                reader.ReadLine();
                int id = 0;
                while (reader.Peek() != -1)
                {
                    string[] s = reader.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string x in s)
                    {
                        Console.WriteLine(x);
                    }
                    id = int.Parse(s[0]);
                    string Ten = s[1];
                    string GioiTinh = s[2];
                    int Tuoi = int.Parse(s[3]);
                    double DiemToan = double.Parse(s[4]);
                    double DiemLy = double.Parse(s[5]);
                    double DiemHoa = double.Parse(s[6]);
                    SinhVien sv = new SinhVien(id, Ten, GioiTinh, Tuoi, DiemToan, DiemLy, DiemHoa);
                    listSV.Add(sv);
                    id++;
                }
                reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public static void AddStudent()
        {
            Console.WriteLine("----- THÊM SINH VIÊN -----");
            Console.Write("Nhập tên sinh viên: ");
            string Ten = Console.ReadLine();
            Console.Write("Nhập giới tính (Nam/Nữ): ");
            string GioiTinh = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            int Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm toán: ");
            double diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý: ");
            double diemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hóa: ");
            double diemHoa = double.Parse(Console.ReadLine());

            int id = listSV.Count > 0 ? listSV[listSV.Count - 1].id + 1 : 1;
            SinhVien student = new SinhVien(id, Ten, GioiTinh, Tuoi, diemToan, diemLy, diemHoa);
            listSV.Add(student);
            Console.WriteLine("Thêm sinh viên thành công.");
        }

        public static void DisplayStudents()
        {
            foreach (SinhVien s in listSV)
            {
                Console.WriteLine($"{s.id}\t{s.Ten}\t{s.GioiTinh}\t{s.Tuoi}\t{s.DiemToan.ToString("F2")}\t{s.DiemLy.ToString("F2")}\t{s.DiemHoa.ToString("F2")}\t{s.DiemTB.ToString("F2")}\t{s.HocLuc}");
            }
            Console.ReadLine();
        }
        public static void UpdateStudent()
        {
            Console.WriteLine("Nhập id sinh viên muốn cập nhật thông tin: ");
            int ID = int.Parse(Console.ReadLine());
            int index = listSV.FindIndex(sv => sv.id == ID);
            if (index >= 0)
            {
                SinhVien sv = listSV[index];
                Console.Write("Nhập tên sinh viên: ");
                sv.Ten = Console.ReadLine();
                Console.Write("Nhập giới tính (Nam/Nữ): ");
                sv.GioiTinh = Console.ReadLine();
                Console.Write("Nhập tuổi: ");
                sv.Tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhập điểm toán: ");
                sv.DiemToan = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm lý: ");
                sv.DiemLy = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm hóa: ");
                sv.DiemHoa = double.Parse(Console.ReadLine());
                sv.DiemTB = (sv.DiemToan + sv.DiemLy + sv.DiemHoa) / 3;
                sv.HocLuc = SinhVien.XepLoai(sv.DiemTB);
                listSV[index] = sv;
                Console.WriteLine($"Đã cập nhật thông tin của sinh viên có ID = {sv.id} thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID đã nhập.");
            }
        }
        public static void DeleteStudent()
        {
            Console.WriteLine("Nhap id sinh viên muốn xóa: ");
            int ID = int.Parse(Console.ReadLine());
            int index = listSV.FindIndex(sv => sv.id == ID);
            listSV.RemoveAt(index);
        }

        public static void SearchStudentsByName()
        {
            Console.WriteLine("Nhập tên sinh viên muốn tìm: ");
            string name = Console.ReadLine();
            List<SinhVien> listSVSearchByName = listSV.FindAll(sv => sv.Ten.ToLower().Contains(name.ToLower()));
            foreach (SinhVien s in listSVSearchByName)
            {
                Console.WriteLine($"{s.id}\t{s.Ten}\t{s.GioiTinh}\t{s.Tuoi}\t{s.DiemToan.ToString("F2")}\t{s.DiemLy.ToString("F2")}\t{s.DiemHoa.ToString("F2")}\t{s.DiemTB.ToString("F2")}\t{s.HocLuc}");
            }
            if (listSVSearchByName.Count == 0)
            {
                Console.WriteLine($"Không tìm thấy sinh viên có tên {name}");
                return;
            }
        }
        public static void SortByAverageScore()
        {
            List<SinhVien> listSVSortByAverageScore = listSV.OrderBy(sv => sv.DiemTB).ToList();
            foreach (SinhVien s in listSVSortByAverageScore)
            {
                Console.WriteLine($"{s.id}\t{s.Ten}\t{s.GioiTinh}\t{s.Tuoi}\t{s.DiemToan.ToString("F2")}\t{s.DiemLy.ToString("F2")}\t{s.DiemHoa.ToString("F2")}\t{s.DiemTB.ToString("F2")}\t{s.HocLuc}");
            }
        }
        public static void SortByName()
        {
            List<SinhVien> listSVSortByName = listSV.OrderBy(sv => sv.Ten).ToList();
            foreach (SinhVien s in listSVSortByName)
            {
                Console.WriteLine($"{s.id}\t{s.Ten}\t{s.GioiTinh}\t{s.Tuoi}\t{s.DiemToan.ToString("F2")}\t{s.DiemLy.ToString("F2")}\t{s.DiemHoa.ToString("F2")}\t{s.DiemTB.ToString("F2")}\t{s.HocLuc}");
            }
        }
        public static void GhiVaoFile()
        {
            StreamWriter writer = new StreamWriter(@"E:\student.txt");
            writer.WriteLine("ID\tTen\tGioiTinh\tTuoi\tDiemToan\tDiemLy\tDiemHoa\tDiemTB\tHocLuc");
            foreach (SinhVien s in listSV)
            {
                writer.WriteLine($"{s.id}\t{s.Ten}\t{s.GioiTinh}\t{s.Tuoi}\t{s.DiemToan.ToString("F2")}\t{s.DiemLy.ToString("F2")}\t{s.DiemHoa.ToString("F2")}\t{s.DiemTB.ToString("F2")}\t{s.HocLuc}");
            }
            writer.Close();
        }
    }
}
