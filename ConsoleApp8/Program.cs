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
                    recipe.Ingredients.Add(ingredient);
                }

                Console.WriteLine("Enter the number of steps:");
                int stepCount = Convert.ToInt32(Console.ReadLine());

                recipe.Steps.Clear();
                for (int i = 0; i < stepCount; i++)
                {
                    Console.WriteLine($"Enter the description for step {i + 1}:");
                    string description = Console.ReadLine();

                    Step step = new Step
                    {
                        Description = description
                    };

                    recipe.Steps.Add(step);
                }

                DisplayRecipe(recipe);

                Console.WriteLine("Enter 'scale' to scale the recipe, 'reset' to reset quantities, 'clear' to clear all data, or any other key to exit:");
                string command = Console.ReadLine();
                if (command == "scale")
                {
                    Console.WriteLine("Enter the scaling factor (0.5, 2, or 3):");
                    double scalingFactor = Convert.ToDouble(Console.ReadLine());
                    ScaleRecipe(recipe, scalingFactor);
                    DisplayRecipe(recipe);
                }
                else if (command == "reset")
                {
                    ResetQuantities(recipe);
                    DisplayRecipe(recipe);
                }
                else if (command == "clear")
                {
                    recipe.Ingredients.Clear();
                    recipe.Steps.Clear();
                }
                else
                {
                    break;
                }
            }
        }
        static void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipe.Steps[i].Description}");
            }
        }