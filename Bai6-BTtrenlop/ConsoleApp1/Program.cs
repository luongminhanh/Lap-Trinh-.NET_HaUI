using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> dsv = new List<Vehicles>();
            
            while (true)
            {
                Console.WriteLine("=========MENU==========");
                Console.WriteLine("1. Nhap du lieu");
                Console.WriteLine("2. Hien thi du lieu");
                Console.WriteLine("3. Tim kiem theo id");
                Console.WriteLine("4. Tim kiem theo maker");
                Console.WriteLine("5. Sap xep theo price");
                Console.WriteLine("6. Sap xep theo nam san xuat");
                Console.WriteLine("7. Ket thuc");
                Console.WriteLine("Nhap vao lua chon: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        for (int i = 0; i<3; i++)
                        {
                            Console.WriteLine($"Lan thu {i}");
                            Car c = new Car();
                            c.Input();
                            Truck t = new Truck();
                            t.Input();
                            dsv.Add(c);
                            dsv.Add(t);
                        }
                        break;
                    case 2:
                        foreach (Vehicles a in dsv)
                        {
                            a.Output();
                            //Console.WriteLine(a.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Nhap id vehicle muon tim: ");
                        string ID = Console.ReadLine();
                        Vehicles v = new Vehicles(ID);
                        int index = dsv.IndexOf(v);
                        if (index != -1)
                        {
                            Console.WriteLine($"Tim thay doi tuong co id = {ID}");
                            dsv[index].Output();
                            dsv[index].id = "133";
                            dsv[index].Output();
                        } else Console.WriteLine("Khong tim thay id");                                               
                        break;
                    case 4:
                        Console.WriteLine("Nhap maker muon tim: ");
                        string maker = Console.ReadLine();
                        foreach (Vehicles s in dsv)
                            if (s.maker == maker)
                                s.Output();
                        break;
                    case 5:
                        dsv = dsv.OrderBy(s => s.price).ToList();
                        break;
                    case 6:
                        dsv =  dsv.OrderBy(s => s.year).ToList();
                        break;
                    case 7:
                        return;
                }
            }
        }
    }
}
