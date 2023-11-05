using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IEnumerableVsIQueryable;

public class BloggingContext : DbContext
{
    public DbSet<Blog>? Blogs { get; set; }

    public DbSet<Post>? Posts { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

public class Blog
{
    public int BlogId { get; set; }

    //[Key]
    //public int BlogKey { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public int BlogId { get; set; }

    public Blog? Blog { get; set; }
}
