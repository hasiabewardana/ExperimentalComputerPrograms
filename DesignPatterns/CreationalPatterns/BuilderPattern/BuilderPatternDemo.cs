using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class BuilderPatternDemo
    {
        // use to demonstrate the Builder Design Pattern
        public static void ExecuteDemo()
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total cost: " + vegMeal.GetCost());

            Console.WriteLine();

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("Non-Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total cost: " + nonVegMeal.GetCost());

            Console.ReadLine();
        }
    }
}
