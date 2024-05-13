using System;
using System.Collections.Generic;

namespace Recipe_App
{
    class RecipeHandler
    {
        private List<Recipe> recipes = new List<Recipe>();

        public void EnterRecipeDetails()
        {
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();
            var recipe = new Recipe { Name = recipeName };

            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the quantity of {name}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter the unit of measurement for {name}: ");
                string unit = Console.ReadLine();

                Console.Write($"Enter the number of calories for {name}: ");
                double calories = double.Parse(Console.ReadLine());

                Console.Write($"Enter the food group for {name}: ");
                string foodGroup = Console.ReadLine();

                recipe.AddIngredient(name, quantity, unit, calories, foodGroup);
            }

            recipes.Add(recipe);
            Console.WriteLine("Recipe details entered successfully.");
        }

        public void DisplayRecipes()
        {
           
            recipes.Sort((r1, r2) => String.Compare(r1.Name, r2.Name)); // Sort recipes alphabetically
            foreach (var recipe in recipes)
            { 
                Console.WriteLine(recipe.Name);
            }
        }

      public void ChooseRecipe()
{
    DisplayRecipes();
    Console.Write("Enter the number of the recipe you want to view: ");
    Console.WriteLine("===============================================");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int choice))
    {
        if (choice >= 0 && choice < recipes.Count)
        {
            recipes[choice].DisplayRecipe();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


        public void ScaleRecipe()
        {
            if (recipes.Count > 0)
            {
                Console.Write("Enter scale factor (0.5, 2, or 3): ");
                double factor = double.Parse(Console.ReadLine());
                recipes[recipes.Count - 1].Scale(factor); 
                Console.WriteLine("Recipe scaled successfully.");
            }
            else
            {
                Console.WriteLine("No recipe available. Please enter recipe details first.");
            }
        }

        public void ResetQuantities()
        {
            if (recipes.Count > 0)
            {
                recipes[recipes.Count - 1].ResetQuantities(); 
                Console.WriteLine("Quantities reset successfully.");
            }
            else
            {
                Console.WriteLine("No recipe available. Please enter recipe details first.");
            }
        }

        public void ClearData()
        {
            recipes.Clear();
            Console.WriteLine("All data cleared.");
        }
    }
}
