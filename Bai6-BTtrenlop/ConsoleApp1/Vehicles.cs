using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicles : IVehicle
    {
        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public Vehicles()
        {

        }

        public Vehicles(string id)
        {
            this.id = id;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap id: ");
            id = Console.ReadLine();
            Console.WriteLine("Nhap maker: ");
            maker = Console.ReadLine();
            Console.WriteLine("Nhap model: ");
            model = Console.ReadLine();
            Console.WriteLine("Nhap year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap price: ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine($"id: {id}\tmaker: {maker}\tmodel: {model}\tyear: {year}\tprice: {price}");
        }

        public override bool Equals(object obj)
        {
            Vehicles v = (Vehicles)obj;
            return (this.id.Equals(v.id));
        }

        public override string ToString()
        {
            var str =  String.Format("{0, -8}{1, -10}{2, -15}{3, -10}{4, -10}", id, maker, model, year, price);
            return str;
        }
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }
    }
}
