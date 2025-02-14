using Microsoft.EntityFrameworkCore;

namespace GymTime.DataAccess
{
    public class GymTimeContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<SubscriptionPackage> SubscriptionPackages { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainingSchedule> TrainingSchedules { get; set; }
        public DbSet<ManagerPassword> ManagerPasswords { get; set; }
        public DbSet<TrainerPassword> TrainerPasswords { get; set; }
        public DbSet<CustomerPassword> CustomerPasswords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymTime;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Schedule)
                .WithOne(s => s.Customer)
                .HasForeignKey<TrainingSchedule>(s => s.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TrainingSchedule>()
                .HasOne(s => s.Trainer)
                .WithMany(t => t.Schedules)
                .HasForeignKey(s => s.TrainerId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
}
