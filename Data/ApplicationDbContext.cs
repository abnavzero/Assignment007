using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment007.Models;

namespace Assignment007.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        //public DbSet<Assignment007.Models.Author> Author { get; set; } = default!;
        
    }
}