namespace Application.Databases.Relational.Models.Users
{
    public class RefreshToken
    {
        //Values
        public int Id { get; set; }
        public string RefreshTokenString { get; set; } = null!;
        public DateTime Expired { get; set; }


        //References
        public Guid UserId { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
