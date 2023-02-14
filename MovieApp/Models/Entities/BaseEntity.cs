using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Isdelete { get; set; }

    }
}
