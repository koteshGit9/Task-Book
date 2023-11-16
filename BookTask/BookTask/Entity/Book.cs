using System.ComponentModel.DataAnnotations;

namespace BookTask.Entity
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(20)]
        public string? BookName { get; set; }
        [Required]
        public int? BookPrice { get; set; }
        [Required]
        public string? BookAuthor { get; set; }
        [Required]
        public string? BookLanguage { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
    }
}
