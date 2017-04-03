using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.SingletonPattern
{
    class Singleton
    {
        // globally accessible single instance
        public static Singleton instance = new Singleton(); 

        // private constructor
        private Singleton()
        {

        }

        // return the only one instance outside
        public static Singleton GetSingletonInstance()
        {
            return instance;
        }

        //useful stuff in that Singleton instance
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
