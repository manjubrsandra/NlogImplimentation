using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogImplimentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");
            Addnum obj = new Addnum();
            obj.Sum(2, 3);
            Console.WriteLine("This is a Logger Demo");
            Console.ReadKey();
        }
    }
}
