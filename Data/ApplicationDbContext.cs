using MusicLibraryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicLibraryWebAPI.Data
{

    public class ApplicationDbContext : DbContext
    {
        public class DbSet{} Song Songs { get; set; }
    public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        
        }
    }
}


