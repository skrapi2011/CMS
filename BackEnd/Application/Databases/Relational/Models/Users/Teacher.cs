namespace Application.Databases.Relational.Models.Users
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }

        //Reference
        public virtual User User { get; set; } = null!;
    }
}
