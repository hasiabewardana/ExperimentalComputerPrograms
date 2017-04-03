using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryPatternDemo
    {
        // use to demonstrate the Abstract Factory Design Pattern
        public static void ExecuteDemo()
        {
            //get ShapeFactory object
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("shape");

            //get Shape Rectangle
            Shape shape1 = shapeFactory.GetShape("rectangle");
            shape1.Draw();

            //get Shape Square
            Shape shape2 = shapeFactory.GetShape("square");
            shape2.Draw();

            //get Shape Circle
            Shape shape3 = shapeFactory.GetShape("circle");
            shape3.Draw();

            Console.WriteLine();

            //get ColorFactory object
            AbstractFactory colorFactory = FactoryProducer.GetFactory("color");

            //get Color Red
            Color color1 = colorFactory.GetColor("red");
            color1.Fill();

            //get Color Green
            Color color2 = colorFactory.GetColor("green");
            color2.Fill();

            //get Color Blue
            Color color3 = colorFactory.GetColor("blue");
            color3.Fill();

            Console.ReadLine();
        }
    }
}
