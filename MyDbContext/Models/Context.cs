using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Models;

internal class Context : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }

    public Context() 
    {
        Database.Migrate();
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connString = @"Server=(localdb)\MSSQLLocalDB;
                                    Database=Popa;
                                    Trusted_Connection=True;";
        optionsBuilder.UseSqlServer(connString);
    }
}
