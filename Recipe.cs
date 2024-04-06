using System;

namespace Recipe_App
{
    class Recipe
    {
        private string name;
        private Ingredient[] ingredients;
        private string[] steps;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Recipe()
        {
            ingredients = new Ingredient[0];
            steps = new string[0];
        }

        public void SetName(string recipeName)
        {
            Name = recipeName;
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
            Console.WriteLine($"Recipe: {Name}");

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"Ingredient Name: {ingredient.Name}");
                Console.WriteLine($"Quantity: {ingredient.Quantity}");
                Console.WriteLine($"Unit: {ingredient.Unit}");
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
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity = 0;
            }
        }
    }
}