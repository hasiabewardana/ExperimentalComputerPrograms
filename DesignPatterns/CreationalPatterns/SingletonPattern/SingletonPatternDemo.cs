using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.SingletonPattern
{
    public class SingletonPatternDemo
    {
        // use to demonstrate the Singleton Design Pattern
        public static void ExecuteDemo()
        {
            //get the only object from Singleton class
            Singleton.GetSingletonInstance().SayHello();

            Console.ReadLine();
        }
    }
}
