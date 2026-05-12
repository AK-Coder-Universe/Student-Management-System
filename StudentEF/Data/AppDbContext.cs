using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StudentEF.Model;
namespace StudentEF.Data
{
    public class AppDbContext : DbContext
    {
     public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =Aakash\\SQLEXPRESS;Database=StudentDB;Trusted_Connection = True;TrustServerCertificate =True");
        }
    }
}
