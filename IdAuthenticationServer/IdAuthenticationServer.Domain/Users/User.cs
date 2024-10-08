namespace IdAuthenticationServer.Domain.Users;

public sealed class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public List<Role> UserRoles { get; set; }
}
