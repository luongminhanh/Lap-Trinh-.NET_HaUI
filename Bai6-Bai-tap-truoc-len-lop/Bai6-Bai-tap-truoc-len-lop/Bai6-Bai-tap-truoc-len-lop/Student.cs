using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Bai_tap_truoc_len_lop
{
    class Student : Person
    {
        public byte maths { get; set; }
        public byte physics { get; set; }
        public Student()
        {
        
        }
        public Student(int id, string name, string address, byte maths, byte physics):base(id, name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }
        public byte Total()
        {
            return (byte)(maths + physics);
        }
        public new void Input()
        {
            base.Input();
            Console.WriteLine("Diem toan: ");
            maths = byte.Parse(Console.ReadLine());
            Console.WriteLine("Diem ly: ");
            physics = byte.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Toan: {maths}\tly: {physics}");
        }
    }
}
