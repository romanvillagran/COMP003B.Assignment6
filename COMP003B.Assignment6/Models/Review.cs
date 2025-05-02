using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Review text is required!")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Rating is required!")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        public int MovieId { get; set; }

        public virtual Movie? Movie { get; set; }
    }
}
