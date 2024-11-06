using Application.Databases.Relational.Models.Groups;

namespace Application.Databases.Relational.Models.Users
{
    public class Student
    {
        //Values
        public Guid StudentId { get; set; }


        //References
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
