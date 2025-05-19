using Microsoft.EntityFrameworkCore;
using PersonApi.Models;
using System.Collections.Generic;

namespace PersonApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}
