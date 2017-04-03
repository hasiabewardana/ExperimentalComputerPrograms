using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    class ShapeCache
    {
        private static Dictionary<string, Shape> dictionary = new Dictionary<string, Shape>(); // behaves like a cache

        // return clonned concrete instance of type Shape from the cache
        public static Shape GetShape(string shapeId)
        {
            Shape cachedShape = dictionary[shapeId];
            return (Shape)cachedShape.Clone();
        }

        // for each shape run database query and create shape
        // dictionary.Add(shapeKey, shape);
        // for example, we are adding three shapes
        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.SetId("1");
            dictionary.Add(circle.GetId(), circle);

            Square square = new Square();
            square.SetId("2");
            dictionary.Add(square.GetId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetId("3");
            dictionary.Add(rectangle.GetId(), rectangle);
        }
    }
}
