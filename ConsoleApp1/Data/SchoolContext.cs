using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Marks> Marks { get; set; }

        public DbSet<Subjects> Subjects { get; set; }

        public DbSet<Teachers> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True");
        }
    }
}
