﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square - Draw() method");
        }
    }
}
