using System;

namespace Recipe_App
{
    class Recipe
    {
        private Ingredient[] ingredients;
        private string[] steps;

        public Recipe()
        {
            ingredients = new Ingredient[0];
            steps = new string[0];
        }

        public void AddIngredient(string name, double quantity, string unit)
        {
            Array.Resize(ref ingredients, ingredients.Length + 1);
            ingredients[ingredients.Length - 1] = new Ingredient(name, quantity, unit);
        }

        public void AddStep(string step)
        {
            Array.Resize(ref steps, steps.Length + 1);
            steps[steps.Length - 1] = step;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        public void Scale(double factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
           
        }
    }
}
