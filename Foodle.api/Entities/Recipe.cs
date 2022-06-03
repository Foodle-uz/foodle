namespace Foodle.api.Entities
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] RecipeImage { get; set; } = new byte[] { };
        public int Difficulty { get; set; }
        public int PreparationTime { get; set; }
        public int Rating { get; set; }
        public User Author { get; set; }
        public string[] Tags { get; set; } = new string[] {};
        public string[] Warnings { get; set; } = new string[] { };
        public CousineEnum Cousine { get; set; }
        public IEnumerable<Publication> PublicaitonsWithRecipe { get; set; } = Enumerable.Empty<Publication>();
        public int Calories { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; } = Enumerable.Empty<Ingredient>();
        public IEnumerable<Step> Steps { get; set; } = Enumerable.Empty<Step>();
        public int RecipePrice { get; set; }
        public int IngredientsPrice { get; set; }
    }
}