
using System.Data.Entity;

namespace Hotel
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base("DbConnect")
        {

        }

        public DbSet<Resident> Residents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
