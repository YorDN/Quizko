using System.ComponentModel.DataAnnotations;

namespace Quizko.Data.Models.Quizes
{
    public class Subject
    {
        [Key]
        public Guid Id { get; set; }

        [Required] 
        public string Name { get; set; } = null!;

        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}