namespace Application.Databases.Relational.Models.Users
{
    public class Admin
    {
        public Guid AdminId { get; set; }

        //Reference
        public virtual User User { get; set; } = null!;
    }
}
