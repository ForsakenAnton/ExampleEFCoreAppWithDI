namespace HelloEFCoreApp.Data.Entities;

public class Course
{
    public int Id { get; set; }
    public string? Title { get; set; }

    public ICollection<StudentCourse>? StudentCourses { get; set; }
    public ICollection<CourseInstructor>? CourseInstructors { get; set; }
}
