using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuongMinhAnh_202160336_proj52
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Input();
            e.Output();

            GiaiPTBac2 pt = new GiaiPTBac2();
            pt.Input();
            pt.Output();
            pt.giai();

            TimUSCLN[] ds = new TimUSCLN[1000];
            for (int i = 0; i < 5; i++)
            {
                ds[i] = new TimUSCLN();
                ds[i].Input();
            }
            for (int i = 0; i < 5; i++)
            {
                ds[i].output();
            }
           
            
            List<TimUSCLN> dsl = new List<TimUSCLN>(1000);
            for (int i = 0; i < 5; i++)
            {
                TimUSCLN s = new TimUSCLN();
                s.Input();
                dsl.Add(s);
            }
            for (int i = 0; i < 5; i++)
            {
                dsl[i].output();
            }

            Console.ReadLine();
        }
    }
}
