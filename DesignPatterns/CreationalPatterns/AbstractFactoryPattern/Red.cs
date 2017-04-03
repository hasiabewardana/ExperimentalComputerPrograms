using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    class Red : Color
    {
        public void Fill()
        {
            Console.WriteLine("Inside Red - Fill() method");
        }
    }
}
