namespace admStudentSecurity
{
	using System.Data.Entity;
	public class DataContext : DbContext
	{
		public DataContext() : base("DefaultConnection")
		{

		}
		public System.Data.Entity.DbSet<admStudentSecurity.Student> Students { get; set; }
	}
}