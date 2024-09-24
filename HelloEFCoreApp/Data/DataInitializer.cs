using HelloEFCoreApp.Data.Entities;

namespace HelloEFCoreApp.Data;

public static class DataInitializer
{
    public static async Task Init(ApplicationDbContext context)
    {
        if (context.Students.Any() ||
          context.Courses.Any() ||
          context.Instructors.Any())
        {
            return;
        }

        var students = new List<Student>
    {
      new Student { Name = "John Doe" },
      new Student { Name = "Jane Smith" },
      new Student { Name = "Alice Johnson" },
      new Student { Name = "Bob Brown" },
      new Student { Name = "Charlie Davis" },
      new Student { Name = "Diana Evans" },
      new Student { Name = "Eve Green" },
      new Student { Name = "Frank Harris" },
      new Student { Name = "Grace Ivers" },
      new Student { Name = "Hank Jones" },
      new Student { Name = "Ivy King" },
      new Student { Name = "Jack Lee" },
      new Student { Name = "Kara Moore" },
      new Student { Name = "Leo Nguyen" },
      new Student { Name = "Mona O'Neil" },
      new Student { Name = "Nina Perez" },
      new Student { Name = "Oscar Quinn" },
      new Student { Name = "Paul Roberts" },
      new Student { Name = "Quinn Stone" },
      new Student { Name = "Rita Taylor" }
    };

        var courses = new List<Course>
    {
      new Course { Title = "Mathematics" },
      new Course { Title = "Physics" },
      new Course { Title = "Chemistry" },
      new Course { Title = "Biology" },
      new Course { Title = "Computer Science" },
      new Course { Title = "History" },
      new Course { Title = "Philosophy" },
      new Course { Title = "Economics" },
      new Course { Title = "Psychology" },
      new Course { Title = "Sociology" },
      new Course { Title = "Political Science" },
      new Course { Title = "Literature" },
      new Course { Title = "Art History" },
      new Course { Title = "Music Theory" },
      new Course { Title = "Engineering" },
      new Course { Title = "Statistics" },
      new Course { Title = "Law" },
      new Course { Title = "Medicine" },
      new Course { Title = "Nursing" },
      new Course { Title = "Education" }
    };

        var instructors = new List<Instructor>
    {
      new Instructor { Name = "Prof. Emily Allen" },
      new Instructor { Name = "Dr. Michael Baker" },
      new Instructor { Name = "Prof. Sarah Clark" },
      new Instructor { Name = "Dr. David Davis" },
      new Instructor { Name = "Prof. Fiona Edwards" },
      new Instructor { Name = "Dr. George Foster" },
      new Instructor { Name = "Prof. Helen Gray" },
      new Instructor { Name = "Dr. Ian Howard" },
      new Instructor { Name = "Prof. Jessica Ivy" },
      new Instructor { Name = "Dr. Kevin Johnson" }
    };

        var studentCourses = new List<StudentCourse>
    {
      new StudentCourse { Student = students[0], Course = courses[0] },
      new StudentCourse { Student = students[0], Course = courses[1] },
      new StudentCourse { Student = students[1], Course = courses[2] },
      new StudentCourse { Student = students[1], Course = courses[3] },
      new StudentCourse { Student = students[2], Course = courses[4] },
      new StudentCourse { Student = students[2], Course = courses[5] },
      new StudentCourse { Student = students[3], Course = courses[6] },
      new StudentCourse { Student = students[3], Course = courses[7] },
      new StudentCourse { Student = students[4], Course = courses[8] },
      new StudentCourse { Student = students[4], Course = courses[9] },
      new StudentCourse { Student = students[5], Course = courses[10] },
      new StudentCourse { Student = students[5], Course = courses[11] },
      new StudentCourse { Student = students[6], Course = courses[12] },
      new StudentCourse { Student = students[6], Course = courses[13] },
      new StudentCourse { Student = students[7], Course = courses[14] },
      new StudentCourse { Student = students[7], Course = courses[15] },
      new StudentCourse { Student = students[8], Course = courses[16] },
      new StudentCourse { Student = students[8], Course = courses[17] },
      new StudentCourse { Student = students[9], Course = courses[18] },
      new StudentCourse { Student = students[9], Course = courses[19] }
    };

        var courseInstructors = new List<CourseInstructor>
    {
      new CourseInstructor { Course = courses[0], Instructor = instructors[0] },
      new CourseInstructor { Course = courses[1], Instructor = instructors[0] },
      new CourseInstructor { Course = courses[2], Instructor = instructors[1] },
      new CourseInstructor { Course = courses[3], Instructor = instructors[1] },
      new CourseInstructor { Course = courses[4], Instructor = instructors[2] },
      new CourseInstructor { Course = courses[5], Instructor = instructors[2] },
      new CourseInstructor { Course = courses[6], Instructor = instructors[3] },
      new CourseInstructor { Course = courses[7], Instructor = instructors[3] },
      new CourseInstructor { Course = courses[8], Instructor = instructors[4] },
      new CourseInstructor { Course = courses[9], Instructor = instructors[4] },
      new CourseInstructor { Course = courses[10], Instructor = instructors[5] },
      new CourseInstructor { Course = courses[11], Instructor = instructors[5] },
      new CourseInstructor { Course = courses[12], Instructor = instructors[6] },
      new CourseInstructor { Course = courses[13], Instructor = instructors[6] },
      new CourseInstructor { Course = courses[14], Instructor = instructors[7] },
      new CourseInstructor { Course = courses[15], Instructor = instructors[7] },
      new CourseInstructor { Course = courses[16], Instructor = instructors[8] },
      new CourseInstructor { Course = courses[17], Instructor = instructors[8] },
      new CourseInstructor { Course = courses[18], Instructor = instructors[9] },
      new CourseInstructor { Course = courses[19], Instructor = instructors[9] }
    };

        await context.Students.AddRangeAsync(students);
        await context.Courses.AddRangeAsync(courses);
        await context.Instructors.AddRangeAsync(instructors);
        await context.StudentCourses.AddRangeAsync(studentCourses);
        await context.CourseInstructors.AddRangeAsync(courseInstructors);

        await context.SaveChangesAsync();
    }
}
