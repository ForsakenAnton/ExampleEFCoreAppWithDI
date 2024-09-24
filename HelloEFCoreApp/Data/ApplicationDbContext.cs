using HelloEFCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HelloEFCoreApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<CourseInstructor> CourseInstructors { get; set; }



    public static readonly ILoggerFactory? MyLoggerFactory = LoggerFactory.Create(configure =>
    {
        configure.AddConsole();
    });

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string? connStr = config.GetConnectionString("SqlServerConnection");
        //string? connStr = config.GetConnectionString("SQLiteConnection");

        optionsBuilder.UseSqlServer(connStr);
        // optionsBuilder.UseSqlite(connStr);

        optionsBuilder.UseLoggerFactory(MyLoggerFactory);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<StudentCourse>()
        //  .HasKey(e => new { e.StudentId, e.CourseId }); // складений Foreign Key

        //modelBuilder.Entity<CourseInstructor>()
        //  .HasKey(ci => new { ci.CourseId, ci.InstructorId }); // складений Foreign Key

        // UNIQUE ('StudentId', 'CourseId')
        modelBuilder.Entity<StudentCourse>()
            .HasAlternateKey(sc => new { sc.StudentId, sc.CourseId });

        // UNIQUE ('InstructorId', 'CourseId')
        modelBuilder.Entity<CourseInstructor>()
            .HasAlternateKey(ci => new { ci.InstructorId, ci.CourseId });
    }
}
