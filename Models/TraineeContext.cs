using Microsoft.EntityFrameworkCore;                                    // Needed for DbContext and DbSet

// This class represents the database context.
// It's responsible for managing the connection to the database and providing access to the Trainees table.

namespace WebAppTrainees.Models
{
    public class TraineeContext : DbContext
    {
        public TraineeContext()
        {
        }
        public TraineeContext(DbContextOptions<TraineeContext> options) : base(options)
        {
        }

        // static string connectionstring = @"Data Source=IBM-GJ63SB4\SQLEXPRESS;Initial Catalog=TraineeDB;TrustServerCertificate= True;Integrated Security=True;";

        // Represents the Trainee Table in the Database
        public DbSet<Trainee> Trainees { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Check if the optionsBuilder is already configured

            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
                //optionsBuilder.UseSqlServer(connectionstring);

            }
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainee>().ToTable("Trainees");
            base.OnModelCreating(modelBuilder);
        }*/
    }
}

/*
Dependency Injection (DI) is a design pattern that lets ASP.NET Core automatically provide instances of classes (like TraineeContext) to your controllers or services. 
 */