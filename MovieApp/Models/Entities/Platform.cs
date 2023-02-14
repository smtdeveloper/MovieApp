namespace MovieApp.Models.Entities
{
    public class Platform : BaseEntity
    {
        public int Name { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
