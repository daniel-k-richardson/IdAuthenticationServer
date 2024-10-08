namespace IdAuthenticationServer.Domain.Users;

public interface IUserRepository
{
    public Task<User> GetUserByIdAsync(Guid id);
    public Task<User> AddUserAsync(User user);
    public Task<User> UpdateUserAsync(User user);
    public Task<User> DeleteUserAsync(Guid id);
}
