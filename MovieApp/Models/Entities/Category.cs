namespace MovieApp.Models.Entities
{
    public class Category : BaseEntity
    {
        public int Name { get; set; }
        public ICollection<MovieCategory> MovieCategories { get; set; }

    }
}
