namespace Application.Databases.Relational.Models.Users
{
    public class Admin
    {
        //Values
        public Guid AdminId { get; set; }


        //References
        public virtual User User { get; set; } = null!;
    }
}
