using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Core.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required]
        [StringLength(100)]
        public string? Author { get; set; }
    }
}
