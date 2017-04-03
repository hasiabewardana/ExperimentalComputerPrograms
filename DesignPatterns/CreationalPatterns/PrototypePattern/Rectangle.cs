using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    class Rectangle : Shape
    {
        public Rectangle()
        {
            type = "Rectangle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle: Draw() method.");
        }
    }
}
