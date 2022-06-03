namespace Foodle.api.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public User OrderedUser { get; set; }
        public IEnumerable<Ingredient> OrderedIngredients { get; set; } = Enumerable.Empty<Ingredient>();
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatusEnum Status { get; set; }
        public int MyProperty { get; set; }
    }
}