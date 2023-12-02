using Microsoft.EntityFrameworkCore;
using Najot.Domain.Entity.Users;

namespace Najot.Infrastructure.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
		Database.Migrate();
	}

	public	DbSet<User> Users { get; set; }

}
