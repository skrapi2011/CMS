namespace Application.Databases.Relational.Models.Users
{
    public class User
    {
        //Values
        public Guid UserId { get; set; }
        public string Login { get; set; } = null!; //As Email
        public string Password { get; set; } = null!;


        //References
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
        //1 to 0..1 => Overlapping
        public virtual Student? Student { get; set; } = null;
        public virtual Teacher? Teacher { get; set; } = null;
        public virtual Admin? Admin { get; set; } = null;
    }
}
