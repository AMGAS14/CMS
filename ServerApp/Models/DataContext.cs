using Microsoft.EntityFrameworkCore;
namespace ServerApp.Models
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> opts)
		: base(opts) { }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Rating> Ratings { get; set; }

	}
}