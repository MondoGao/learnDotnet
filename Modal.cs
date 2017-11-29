using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace learnDotnet
{
    class TestDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public TestDbContext() : base() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1401;Database=Test;User ID=sa;Password=<YourStrong!Passw0rd>;");
        }
    }

    public class Student {
        public int id { get; set; }
        public string name { get; set; }
    }
}