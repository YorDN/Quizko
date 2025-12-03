using Microsoft.EntityFrameworkCore;
using Quizko.Data.Models.Enumerations;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizko.Data.Models.Quizes
{
    public class Question
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string Title { get; set; }

        [Required]
        public Guid TestId { get; set; }
        [Required]
        [ForeignKey(nameof(TestId))]
        public Test Test { get; set; } = null!;

        public Difficulty Difficulty { get; set; } = Difficulty.Medium;

        [Required]
        [MaxLength(300)]
        [MinLength(1)]
        [Comment("The time given for the question in seconds")]
        public uint Time { get; set; }

        [Required]
        public Subject Subject { get; set; } = null!;

        [Required]
        public QuestionType Type { get; set; }

        [Required]
        public required string Image { get; set; }

        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}