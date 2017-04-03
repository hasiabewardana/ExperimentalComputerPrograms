using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    interface Item
    {
        string Name();
        Packing Packing();
        float Price();
    }
}
