using Application.Databases.Relational.Models.Courses;

namespace Application.Databases.Relational.Models.Users
{
    public class Teacher
    {
        //Values
        public Guid TeacherId { get; set; }


        //References
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
