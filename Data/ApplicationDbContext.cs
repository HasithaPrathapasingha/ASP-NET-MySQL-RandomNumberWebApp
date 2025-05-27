using Microsoft.EntityFrameworkCore;
using RandomNumberWebApp.Models;

namespace RandomNumberWebApp.Data{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options){
        public DbSet<RandomNumber> RandomNumbers {get; set;}
    }
}