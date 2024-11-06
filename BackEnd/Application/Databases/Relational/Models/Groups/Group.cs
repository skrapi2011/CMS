using Application.Databases.Relational.Models.Users;

namespace Application.Databases.Relational.Models.Groups
{
    public class Group
    {
        //Values
        public Guid GroupId { get; set; }


        //References
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
