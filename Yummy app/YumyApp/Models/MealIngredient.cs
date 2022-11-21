namespace YumyApp.Models
{
    public class MealIngredient
    {
        public int Id { get; set; }
        public int MealId { get; set;}
        public int IngredientId { get; set; }

        public Meal Meal { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
