using VideoGameApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace VideoGameApi.Data.Context
{
    public class VideoGameDbContext : DbContext
    {
        public VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : base(options)
        {

        }
        public DbSet<VideoGameEntity> Games {  get; set; }
        public DbSet<UserEntity> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGameEntity>().ToTable("Games");
            base.OnModelCreating(modelBuilder);
        }
    }
}
