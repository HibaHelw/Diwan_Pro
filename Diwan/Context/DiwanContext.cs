
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiwanModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DiwanModels.Context
{
    public class DiwanContext : DbContext
    {
        #region context

        private string ConnectionString { get; } =
            "Data Source=.\\SQLEXPRESS2014; Initial Catalog=Diwan; Integrated Security=True";
        public DiwanContext() { }
        public DiwanContext(string connectionString)
        {
            ConnectionString = connectionString;
            // ConnectionString = "Data Source=.\\SQLEXPRESS2014; Initial Catalog=Procurement; Integrated Security=True";
            // This will [try to] create database
            // and apply all necessary migrations
            //base.Database.Migrate();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Diwan");
        }
        #endregion

        #region DbSets
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<PostState> PostStates { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostEmployee> PostEmployees { get; set; }


        #endregion
    }
}

