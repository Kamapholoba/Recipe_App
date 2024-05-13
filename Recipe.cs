using System;
using System.Collections.Generic;

namespace Recipe_App
{
    class Recipe
    {
        private string name;
        private List<Ingredient> ingredients; 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Recipe()
        {
            ingredients = new List<Ingredient>();
        }

        public void SetName(string recipeName)
        {
            Name = recipeName;
        }

        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            ingredients.Add(new Ingredient(name, quantity, unit, calories, foodGroup));
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            double totalCalories = 0;

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"Ingredient Name: {ingredient.Name}");
                Console.WriteLine($"Quantity: {ingredient.Quantity} {ingredient.Unit}");
                Console.WriteLine($"Calories: {ingredient.Calories}");
                Console.WriteLine($"Food Group: {ingredient.FoodGroup}");
                totalCalories += ingredient.Calories * ingredient.Quantity;
            }
              

            Console.WriteLine($"Total Calories: {totalCalories}");

            // notify the user when the total calories of a recipe exceed 300.
            if (totalCalories > 300)
            {
                Console.WriteLine("Warning: Total calories exceed 300.");
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
