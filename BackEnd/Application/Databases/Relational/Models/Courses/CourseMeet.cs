namespace Application.Databases.Relational.Models.Courses
{
    public class CourseMeet
    {
        //Values
        public Guid CourseTimeId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? Description { get; set; } = null;


        //References
        public Guid CourseId { get; set; }
        public virtual Course Course { get; set; } = null!;

    }
}
