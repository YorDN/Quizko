using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizko.Data.Models.Quizes
{
    public class Review
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public Guid UserId { get; set; }
        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        public string? Title { get; set; }

        [Required]
        [MaxLength(5)]
        [MinLength(1)]
        public byte Rating { get; set; }

        [MaxLength(300)]
        public string? Comment { get; set; }

        public DateTime PublishedOn { get; set; } = DateTime.UtcNow;
    }
}