using System.Data.Entity;

namespace AdressBook
{
	public class PersonContext : DbContext
	{
		public DbSet<Person> People { get; set; }
	}
}