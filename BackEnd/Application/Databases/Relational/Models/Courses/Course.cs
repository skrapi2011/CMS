using Application.Databases.Relational.Models.Users;

namespace Application.Databases.Relational.Models.Courses
{
    public class Course
    {
        //Values
        public Guid CourseId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Path { get; set; } = null;


        //Refrences
        public Guid TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<CourseMeet> CourseTimes { get; set; } = new List<CourseMeet>();
    }
}
