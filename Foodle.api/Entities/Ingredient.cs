namespace Foodle.api.Entities
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public MeasureEnum Measure { get; set; }
        public int Price { get; set; } = 0;
    }
}