using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    public class PrototypePatternDemo
    {
        // use to demonstrate the Prototype Design Pattern
        public static void ExecuteDemo()
        {
            ShapeCache.loadCache();

            Shape clonedShape1 = (Shape)ShapeCache.GetShape("1");
            Console.WriteLine("Shape : " + clonedShape1.GetType());

            Shape clonedShape2 = (Shape)ShapeCache.GetShape("2");
            Console.WriteLine("Shape : " + clonedShape2.GetType());

            Shape clonedShape3 = (Shape)ShapeCache.GetShape("3");
            Console.WriteLine("Shape : " + clonedShape3.GetType());

            Console.ReadLine();
        }
    }
}
