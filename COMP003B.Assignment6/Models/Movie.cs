using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment6.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [Range(1895, 2025)]
        public int Year { get; set; }

        public string? Language { get; set; }
    }
}
