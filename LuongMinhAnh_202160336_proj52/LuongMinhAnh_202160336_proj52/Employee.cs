using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuongMinhAnh_202160336_proj52
{
    class Employee
    {
        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }
        private int _workingdays;
        public int workingdays
        {
            get { return _workingdays; }
            set { _workingdays = value; }
        }
        private double _salary;
        public double salary
        {
            get { return workingdays * PRICE; }
        }
        public const int PRICE = 50;
        public void Input()
        {
            Console.WriteLine("Nhap vao id: ");
            id = Console.ReadLine();
            Console.WriteLine("Nhap vao ten: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap vao tuoi: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so ngay cong: ");
            workingdays = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"ID: {id}, name: {name}, age: {age}, workingdays: {workingdays}, salary: {salary}");
        }
    }
}
