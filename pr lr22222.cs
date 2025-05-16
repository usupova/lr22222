using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.a = 2;
            rect.b = 3;
            rect.ShowDetails();
            double p = rect.P();
            Console.WriteLine($"Периметр: {p}");
            Console.ReadKey();
        }
    }
}
