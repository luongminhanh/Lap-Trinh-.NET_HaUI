using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car : Vehicles 
    {
        public string color { get; set; }
        public Car():base()
        {
        }

        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }        

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap color: ");
            color = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"color: {color}");
        }
    }
}
