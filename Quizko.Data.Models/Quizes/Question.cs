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
        [Comment("The qustion title/content")]
        public required string Title { get; set; }

        [Required]
        public Guid TestId { get; set; }
        [Required]
        [ForeignKey(nameof(TestId))]
        public Test Test { get; set; } = null!;

        [Comment("The difficulty of the question (default: medium)")]
        public Difficulty Difficulty { get; set; } = Difficulty.Medium;

        [Required]
        [MaxLength(300)]
        [MinLength(1)]
        [Comment("The time given for the question in seconds")]
        public uint Time { get; set; }

        [Required]
        [Comment("The subject/cathegory of the question")]
        public Subject Subject { get; set; } = null!;

        [Required]
        [Comment("The question type")]
        public QuestionType Type { get; set; }

        [Comment("Image of the question")]
        public string? Image { get; set; }

        [Comment("How many points the question gives the user if right")]
        public byte? Points { get; set; }

        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}