using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizko.Data.Models.Quizes
{
    public class Answer
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("Shows if an answer iss correct for the given question")]
        public bool IsRight { get; set; }

        [Required]
        [Comment("The content of the answer")]
        public string Content { get; set; } = null!;

        [Required]
        public Guid QuestionId { get; set; }
        [Required]
        [ForeignKey(nameof(QuestionId))]
        public Question Question { get; set; } = null!;

    }
}
