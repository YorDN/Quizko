using Microsoft.EntityFrameworkCore;

using Quizko.Data.Models.Enumerations;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizko.Data.Models.Quizes
{
    /// <summary>
    ///     Test model. Represents a single test in the Quizko system
    /// </summary>
    public class Test
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid UserId { get; set; }
        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Comment("The difficulty of the test")]
        public Difficulty Difficulty { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        [Required]
        [Comment("The language of the test")]
        public required string Language { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public ICollection<TestCathegory> Cathegories { get; set; } = new List<TestCathegory>();
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

    }
}