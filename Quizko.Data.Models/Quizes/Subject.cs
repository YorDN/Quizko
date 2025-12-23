using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Quizko.Data.Models.Quizes
{
    public class Subject
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required] 
        [MaxLength(100)]
        [Comment("The name of the subject")]
        public required string Name { get; set; } = null!;
        
        [MaxLength(500)] 
        [Comment("The description of the subject")]
        public string? Description { get; set; }

        // Questions with the same subject
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}