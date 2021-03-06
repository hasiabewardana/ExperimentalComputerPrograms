﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    abstract class AbstractFactory
    {
        public abstract Shape GetShape(string shape);
        public abstract Color GetColor(string color);
    }
}
