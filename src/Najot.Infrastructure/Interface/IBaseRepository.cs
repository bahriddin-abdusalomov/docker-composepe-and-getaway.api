namespace Najot.Infrastructure.Interface;

public interface IBaseRepository<Tmodel>
{
    public ValueTask<int> CreateAsync(Tmodel model);
    public ValueTask<IList<Tmodel>> GetAllAsync();
}
