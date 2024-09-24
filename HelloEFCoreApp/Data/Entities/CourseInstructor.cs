namespace HelloEFCoreApp.Data.Entities;

public class CourseInstructor
{
    public int Id { get; set; }

    public int InstructorId { get; set; }
    public Instructor? Instructor { get; set; }

    public int CourseId { get; set; }
    public Course? Course { get; set; }
}
