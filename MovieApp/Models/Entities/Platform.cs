namespace MovieApp.Models.Entities
{
    public class Platform : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
