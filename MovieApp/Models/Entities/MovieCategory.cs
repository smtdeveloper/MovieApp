
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models.Entities
{
    public class MovieCategory
    {
        //public int Id { get; set; }

        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Movie  Movie { get; set; }
        public virtual Category  Category { get; set; }

    }
}
