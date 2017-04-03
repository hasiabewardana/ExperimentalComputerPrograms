using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    class ColorFactory : AbstractFactory
    {
        // get a concrete object of type Color based on the provided information
        public override Color GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            else if (color.Equals("red"))
            {
                return new Red();
            }
            else if (color.Equals("green"))
            {
                return new Green();
            }
            else if (color.Equals("blue"))
            {
                return new Blue();
            }
            return null;
        }

        public override Shape GetShape(string shape)
        {
            return null;
        }
    }
}
