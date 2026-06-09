using Microsoft.EntityFrameworkCore;

namespace Producer.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=persons.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Pin = "12345678901234", Name = "Мухамбетов Амир Алмазович", Gender = Gender.Male, BirthDate = new DateTime(2007, 9, 25) },
                new Person { Id = 2, Pin = "98765432109876", Name = "Анарбаев Адилет Максатбекович", Gender = Gender.Male, BirthDate = new DateTime(2007, 12, 1) }
            );
        }
    }
}