using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1);
            c.Area();
            Console.WriteLine(c);

        }
    }
}
