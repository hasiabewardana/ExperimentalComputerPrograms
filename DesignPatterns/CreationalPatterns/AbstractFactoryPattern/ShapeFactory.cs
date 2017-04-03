using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    class ShapeFactory : AbstractFactory
    {
        public override Color GetColor(string color)
        {
            return null;
        }

        // get a concrete object of type Shape based on the provided information
        public override Shape GetShape(string shape)
        {
            if(shape == null)
            {
                return null;
            }
            else if(shape.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if (shape.Equals("square"))
            {
                return new Square();
            }
            else if (shape.Equals("circle"))
            {
                return new Circle();
            }
            return null;
        }
    }
}
