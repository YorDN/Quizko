using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quizko.Data.Models.Quizes;

namespace Quizko.Data;

public class ApplicationDbContext : IdentityDbContext<
        User,
        IdentityRole<Guid>,
        Guid,
        IdentityUserClaim<Guid>,
        IdentityUserRole<Guid>,
        IdentityUserLogin<Guid>,
        IdentityRoleClaim<Guid>,
        IdentityUserToken<Guid>
    >
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Test> Tests { get; set; } = null!;
    public DbSet<Answer> Answers { get; set; } = null!;
    public DbSet<Question> Questions { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    public DbSet<Subject> Subjects { get; set; } = null!;
    public DbSet<TestCategory> TestCategories { get; set; } = null!;

    public DbSet<TestAttempt> TestAttempts { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

}
