using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizko.Data.Models.Quizes
{
    public class TestAttempt
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid UserId { get; set; }
        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public Guid TestId { get; set; }
        [Required]
        [ForeignKey(nameof(UserId))]
        public Test Test { get; set; } = null!;
        [Required]
        public int Score { get; set; }
        [Required]
        public DateTime TakenOn { get; set; }
    }
}
