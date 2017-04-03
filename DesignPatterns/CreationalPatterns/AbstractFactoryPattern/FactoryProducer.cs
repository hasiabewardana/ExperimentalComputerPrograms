using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    class FactoryProducer
    {
        // get a concrete object of type AbstractFactory based on the provided information
        public static AbstractFactory GetFactory(string choice)
        {
            if(choice.Equals("shape"))
            {
                return new ShapeFactory();
            }
            else if (choice.Equals("color"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
