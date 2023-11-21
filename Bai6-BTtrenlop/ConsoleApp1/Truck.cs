using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Truck : Vehicles
    {
        public Truck():base()
        {
        }

        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.truckload = truckload;
        }

        public int truckload { get; set; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap truckload: ");
            truckload = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"trucload: {truckload}");
        }
    }
}
