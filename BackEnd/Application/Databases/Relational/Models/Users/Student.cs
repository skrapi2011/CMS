namespace Application.Databases.Relational.Models.Users
{
    public class Student
    {
        public Guid StudentId { get; set; }

        //Reference
        public virtual User User { get; set; } = null!;
    }
}
