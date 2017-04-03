using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    class Circle : Shape
    {
        public Circle()
        {
            type = "Circle";
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Circle: Draw() method.");
        }
    }
}
