using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    abstract public class Shape
    {
        public abstract void Area();
    }
    public class Circle : Shape
    {
        private double radius;
        public double result;
        public Circle(int radius)
        {
            this.radius = radius;
            
        }
        public override void Area()
        {
            result = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return $"Area of circle is {result}";
        }

    }
}
