using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using EchoRange.Model;


    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }
        public DbSet<Odleglosci> Odleglosc { get; set; }
    }
    

