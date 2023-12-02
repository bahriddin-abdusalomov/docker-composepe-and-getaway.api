using Najot.Domain.Entity.Users;

namespace Najot.Application.Interface.Users
{
    public interface IUserService
    {
        public ValueTask<bool> CreateAsync(User user);
        public ValueTask<IList<User>> GetAllAsync();
    }
}
