using System;
using System.Collections.Generic;

namespace RecipeApp
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }

    class Step
    {
        public string Description { get; set; }
    }
    class Recipe
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("Enter the number of ingredients:");
                int ingredientCount = Convert.ToInt32(Console.ReadLine());

                recipe.Ingredients.Clear();
                for (int i = 0; i < ingredientCount; i++)
                {
                    Console.WriteLine($"Enter the name of ingredient {i + 1}:");
                    string name = Console.ReadLine();

                    Console.WriteLine($"Enter the quantity of ingredient {i + 1}:");
                    double quantity = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Enter the unit of measurement for ingredient {i + 1}:");
                    string unit = Console.ReadLine();

                    Ingredient ingredient = new Ingredient
                    {
                        Name = name,
                        Quantity = quantity,
                        Unit = unit
                    };
