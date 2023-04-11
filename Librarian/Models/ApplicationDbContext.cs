using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Library.sqlite");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
    }
}

