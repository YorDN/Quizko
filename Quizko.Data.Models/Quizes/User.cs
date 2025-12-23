using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace Quizko.Data.Models.Quizes
{
    /// <summary>
    ///     User model inherits IdentityUser<@Guid>. It represents a user in the Quizko system
    /// </summary>
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            this.Id = Guid.NewGuid();
        }
        [Required]
        [Comment("The profile picture of the user")]
        public required string ProfilePicture { get; set; }

        [Required]
        [Comment("When was the user created")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        [Comment("When did the user last log in")]
        public DateTime LastLogin { get; set; }

        [Comment("Is the user's account active")]
        public bool IsActive { get; set; } = true;

        // A collection of the tests that the user has written
        public ICollection<Test> TestsWritten { get; set; } = new List<Test>();
        
        // A collection of the tests that the user has taken
        public ICollection<TestAttempt> TestsTaken { get; set; } = new List<TestAttempt>();

        // A collection of the reviews that the user has written
        public ICollection<Review> Reviews { get; set; } = new List<Review>();


    }
}
