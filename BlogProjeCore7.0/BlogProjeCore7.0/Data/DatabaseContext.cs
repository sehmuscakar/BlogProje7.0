using BlogProjeCore7._0.Entites;
using Microsoft.EntityFrameworkCore;

namespace BlogProjeCore7._0.Data
{
    public class DatabaseContext:DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// override on yaz seçenekler gelecek zaten , veritabanı işlemleri için burası
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=BlogprojeCore7.0; integrated security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // burası da fluent api için dataları eklemek veya değişklik yapmak için 
        {

            modelBuilder.Entity<Category>().HasData( //büyle veri ekledik ,veriyi migration ile db ye gönderdik
                  new Category
                  {
                         Id= 1,
                         Name="Genel",
                      IsActive=true,
                     
                  });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    IsActive =true,
                    IsAdmin=true,
                    Name="Admin",
                    Surname="User",
                    Email="admin@blogger.com",
                    Password="123",
                    UserName="Admin"
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
