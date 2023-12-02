using Najot.Application.Interface.Users;
using Najot.Domain.Entity.Users;
using Najot.Infrastructure.Interface.Users;

namespace Najot.Application.Services.Users;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async ValueTask<bool> CreateAsync(User user)
    {
        int result = await  _userRepository.CreateAsync(user);
        return result > 0;
    }

    public ValueTask<IList<User>> GetAllAsync()
    {
        return _userRepository.GetAllAsync();
    }
}
