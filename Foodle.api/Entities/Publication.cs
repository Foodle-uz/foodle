namespace Foodle.api.Entities
{
    public class Publication
    {
        public Guid PublicationId { get; set; }
        public User PAuthor { get; set; }
        public Recipe PRecipe { get; set; }
        public IEnumerable<byte[]> Media { get; set; } = Enumerable.Empty<byte[]>();
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<Guid> UserIdYummies { get; set; } = Enumerable.Empty<Guid>();
        public bool IsHidden { get; set; }
    }
}