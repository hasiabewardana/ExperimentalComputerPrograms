using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    class Green : Color
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green - Fill() method");
        }
    }
}
