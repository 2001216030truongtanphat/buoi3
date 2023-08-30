using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo goc = new ToaDo() ;
            ToaDo B = new ToaDo(12, 16, "B");
            Console.WriteLine("Goc: " + goc.ToString());
            Console.WriteLine("Diem B: " + B.ToString());
            Console.ReadLine();
        }
    }
}
