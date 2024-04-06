using System;

namespace Recipe_App
{
    class RecipeHandler
    {
        private Recipe recipe;

        public void EnterRecipeDetails()
        {
            recipe = new Recipe();

            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();
            recipe.SetName(recipeName);

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

                recipe.AddIngredient(name, quantity, unit);
            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                string step = Console.ReadLine();
                recipe.AddStep(step);
            }

            Console.WriteLine("Recipe details entered successfully.");
        }

        public void ViewRecipe()
        {
            if (recipe != null)
                recipe.DisplayRecipe();
            else
                Console.WriteLine("No recipe available. Please enter recipe details first.");
        }

        public void ScaleRecipe()
        {
            if (recipe != null)
            {
                Console.Write("Enter scale factor (0.5, 2, or 3): ");
                double factor = double.Parse(Console.ReadLine());
                recipe.Scale(factor);
                Console.WriteLine("Recipe scaled successfully.");
            }
            else
            {
                Console.WriteLine("No recipe available. Please enter recipe details first.");
            }
        }

        public void ResetQuantities()
        {
            if (recipe != null)
            {
                recipe.ResetQuantities();
                Console.WriteLine("Quantities reset successfully.");
            }
            else
            {
                Console.WriteLine("No recipe available. Please enter recipe details first.");
            }
        }

        public void ClearData()
        {
            recipe = null;
            Console.WriteLine("All data cleared.");
        }
    }
}