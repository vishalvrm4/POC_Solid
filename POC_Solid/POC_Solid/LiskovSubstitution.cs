using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Solid
{
    /// <summary>
    /// Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.

    /// Example:
    ///     Ensuring derived classes are substitutable for their base classes.
    /// </summary>

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
