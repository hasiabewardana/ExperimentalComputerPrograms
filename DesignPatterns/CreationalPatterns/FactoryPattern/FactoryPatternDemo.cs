using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class FactoryPatternDemo
    {
        // use to demonstrate the Factory Design Pattern
        public static void ExecuteDemo()
        {
            //get ShapeFactory object
            ShapeFactory shapeFactory = new ShapeFactory();

            //get Shape Rectangle
            Shape shape1 = shapeFactory.GetShape("rectangle");
            shape1.Draw();

            //get Shape Square
            Shape shape2 = shapeFactory.GetShape("square");
            shape2.Draw();

            //get Shape Circle
            Shape shape3 = shapeFactory.GetShape("circle");
            shape3.Draw();

            Console.ReadLine();
        }
    }
}
