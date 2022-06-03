namespace Foodle.api.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public byte[] ProfilePhoto { get; set; } = new byte[] { };
        public IEnumerable<Recipe> Recipes { get; set; } = Enumerable.Empty<Recipe>();
        public IEnumerable<Publication> Publicaitons { get; set; } = Enumerable.Empty<Publication>();
        public IEnumerable<User> Followers { get; set; } = Enumerable.Empty<User>();
        public IEnumerable<User> Following { get; set; } = Enumerable.Empty<User>();
        public IEnumerable<Order> OrderHistory { get; set; } = Enumerable.Empty<Order>();
        public string Location { get; set; }
    }
}
