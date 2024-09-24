namespace HelloEFCoreApp.Data.Entities;

public class Instructor
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<CourseInstructor>? CourseInstructors { get; set; }
}
