using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace MyLibary.Models
{
    public class BookContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connecting with the SQL server
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q065UFG;Initial Catalog=BookDb;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<BooksToRead> BooksToRead { get; set; }
        public DbSet<CurrentBooks> CurrentBooks { get; set; }
    }


}
