using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    abstract class Shape : ICloneable // implements ICloneable interface
    {
        private string id;
        protected string type;

        public abstract void Draw();

        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetId()
        {
            return id;
        }

        public string GetType()
        {
            return type;
        }

        // implements the Clone() method of ICloneable interface
        public object Clone()
        {
            object clone = null;

            try
            {
                clone = this.MemberwiseClone(); // create a shallow copy of the current object
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return clone;
        }
    }
}
