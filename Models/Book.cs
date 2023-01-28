using System.ComponentModel.DataAnnotations;

namespace Assignment007.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
    }
    
}
