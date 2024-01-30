using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parpera.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace Parpera.DbContext
{
    public class ParperaDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<TransactionEntity> Transaction { get; set; }

        public ParperaDbContext(DbContextOptions<ParperaDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionEntity>().HasIndex(p => new { p.ID, p.Datetime, p.Description, p.Amount, p.Status}).IsUnique();

            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 11,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 10,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 9,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 8,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 7,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 6,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 5,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 4,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 3,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 2,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
            modelBuilder.Entity<TransactionEntity>().HasData(

                new TransactionEntity
                {
                    ID = 1,
                    Datetime = DateTime.Parse("2020-09-08T16:34:23Z"),
                    Description = "Bank Deposit",
                    Amount = 500.00m,
                    Status = "Completed"
                }
            );
        }


        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=parpera.db");
        }*/
    }

}