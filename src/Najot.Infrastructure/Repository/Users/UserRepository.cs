using Najot.Domain.Entity.Users;
using Najot.Infrastructure.Data;
using Najot.Infrastructure.Interface.Users;

namespace Najot.Infrastructure.Repository.Users;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(User model)
    {
        await _dbContext.Users.AddAsync(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<IList<User>> GetAllAsync()
    {
        var users  = _dbContext.Users.ToList();
        return users;
    }
}
