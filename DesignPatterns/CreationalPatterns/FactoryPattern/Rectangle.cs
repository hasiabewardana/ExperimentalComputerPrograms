using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle - Draw() method");
        }
    }
}
