using Microsoft.EntityFrameworkCore;

namespace EF_Core_Cascade_Delete.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
       // public DbSet<Post> Posts { get; set; }

        public DbSet<Person> People { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder
            //    .Entity<Blog>()
            //    .HasOne(e => e.Owner)
            //    .WithOne(e => e.OwnedBlog)
            //    .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
                .Entity<Person>()
                .HasMany(e => e.OwnedBlog)
                .WithOne(x => x.Owner)
               // .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
                

        }
    }
}
