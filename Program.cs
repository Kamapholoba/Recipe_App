using System;

namespace Recipe_App
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeManager recipeManager = new RecipeManager();
            bool continueProgram = true;

            Console.WriteLine("Welcome to the Recipe Application!");

            while (continueProgram)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("1. Enter Recipe Details");
                Console.WriteLine("2. View Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Quantities");
                Console.WriteLine("5. Clear All Data");
                Console.WriteLine("6. Exit");
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
                            recipeManager.ViewRecipe();
                            break;
                        case 3:
                            recipeManager.ScaleRecipe();
                            break;
                        case 4:
                            recipeManager.ResetQuantities();
                            break;
                        case 5:
                            recipeManager.ClearData();
                            break;
                        case 6:
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
