using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Quizko.Data.Models.Quizes
{
    public class TestCategory
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        [Comment("The name of the category")]
        public required string Name { get; set; }

        [MaxLength(500)]
        [Comment("The description of the category")]
        public string? Description { get; set; }

        // A collection of the tests with the same category
        public ICollection<Test> Tests { get; set; } =  new List<Test>(); 
    }
}