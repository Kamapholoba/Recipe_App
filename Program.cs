using System;
using Recipe_App; // Ensure this using directive is correct based on your project structure

namespace Recipe_App
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeHandler recipeManager = new RecipeHandler();
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("===============================================");
                 
                Console.WriteLine("1. Enter Recipe Details");
                Console.WriteLine("2. View Recipes");
                Console.WriteLine("3. Choose Recipe");
                Console.WriteLine("4. Scale Recipe");
                Console.WriteLine("5. Reset Quantities");
                Console.WriteLine("6. Clear All Data");
                Console.WriteLine("7. Exit");
                Console.WriteLine("===============================================");
                Console.WriteLine("===============================================");
                Console.WriteLine("===============================================");
                Console.WriteLine("===============================================");
                

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            recipeManager.EnterRecipeDetails();
                            break;
                        case 2:
                            recipeManager.DisplayRecipes();
                            break;
                        case 3:
                            recipeManager.ChooseRecipe();
                            break;
                        case 4:
                            recipeManager.ScaleRecipe();
                            break;
                        case 5:
                            recipeManager.ResetQuantities();
                            break;
                        case 6:
                            recipeManager.ClearData();
                            break;
                        case 7:
                            continueProgram = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
