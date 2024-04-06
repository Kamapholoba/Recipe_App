using System;

namespace Recipe_App
{
    class RecipeHandler
    {
        private Recipe recipe;

        // Method to enter details for a new recipe, including name, ingredients, and steps.
        public void EnterRecipeDetails()
        {
            recipe = new Recipe();

            // Prompt user to enter the name of the recipe.
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();
            recipe.SetName(recipeName);

            // Prompt user to enter the number of ingredients and details for each ingredient.
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

            // Prompt user to enter the number of steps and details for each step.
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

        // Method to view the details of the current recipe.
        public void ViewRecipe()
        {
            if (recipe != null)
                recipe.DisplayRecipe();
            else
                Console.WriteLine("No recipe available. Please enter recipe details first.");
        }

        // Method to scale the quantities of ingredients in the current recipe by a specified factor.
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

        // Method to reset the quantities of ingredients in the current recipe to zero.
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

        // Method to clear the current recipe data.
        public void ClearData()
        {
            recipe = null;
            Console.WriteLine("All data cleared.");
        }
    }
}
