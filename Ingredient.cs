namespace Recipe_App
{
    class Ingredient
    {
        public string Name { get; }
        public double Quantity { get; set; }
        public string Unit { get; }
        public double Calories { get; set; } // New property for calories
        public string FoodGroup { get; set; } // New property for food group

        public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }
}
