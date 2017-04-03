using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    class ShapeFactory
    {
        // get a concrete object of type Shape based on the provided information
        public Shape GetShape(string shapeType)
        {
            if(shapeType == null)
            {
                return null;
            }
            else if(shapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if(shapeType.Equals("square"))
            {
                return new Square();
            }
            else if(shapeType.Equals("circle"))
            {
                return new Circle();
            }

            return null;
        }
    }
}
