using Microsoft.EntityFrameworkCore;

namespace EfCoreCompiledModels.Models;

public class BloggingContext : DbContext
{
    public DbSet<Blog001> Blogs001 { get; set; }
    public DbSet<Blog002> Blogs002 { get; set; }
    public DbSet<Blog003> Blogs003 { get; set; }
    public DbSet<Blog004> Blogs004 { get; set; }
    public DbSet<Blog005> Blogs005 { get; set; }
    public DbSet<Blog006> Blogs006 { get; set; }
    public DbSet<Blog007> Blogs007 { get; set; }
    public DbSet<Blog008> Blogs008 { get; set; }
    public DbSet<Blog009> Blogs009 { get; set; }
    public DbSet<Blog010> Blogs010 { get; set; }
    public DbSet<Blog011> Blogs011 { get; set; }
    public DbSet<Blog012> Blogs012 { get; set; }
    public DbSet<Blog013> Blogs013 { get; set; }
    public DbSet<Blog014> Blogs014 { get; set; }
    public DbSet<Blog015> Blogs015 { get; set; }
    public DbSet<Blog016> Blogs016 { get; set; }
    public DbSet<Blog017> Blogs017 { get; set; }
    public DbSet<Blog018> Blogs018 { get; set; }
    public DbSet<Blog019> Blogs019 { get; set; }
    public DbSet<Blog020> Blogs020 { get; set; }

    public DbSet<Post001> Posts001 { get; set; }
    public DbSet<Post002> Posts002 { get; set; }
    public DbSet<Post003> Posts003 { get; set; }
    public DbSet<Post004> Posts004 { get; set; }
    public DbSet<Post005> Posts005 { get; set; }
    public DbSet<Post006> Posts006 { get; set; }
    public DbSet<Post007> Posts007 { get; set; }
    public DbSet<Post008> Posts008 { get; set; }
    public DbSet<Post009> Posts009 { get; set; }
    public DbSet<Post010> Posts010 { get; set; }
    public DbSet<Post011> Posts011 { get; set; }
    public DbSet<Post012> Posts012 { get; set; }
    public DbSet<Post013> Posts013 { get; set; }
    public DbSet<Post014> Posts014 { get; set; }
    public DbSet<Post015> Posts015 { get; set; }
    public DbSet<Post016> Posts016 { get; set; }
    public DbSet<Post017> Posts017 { get; set; }
    public DbSet<Post018> Posts018 { get; set; }
    public DbSet<Post019> Posts019 { get; set; }
    public DbSet<Post020> Posts020 { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "EfCoreCompiledModels.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
        //optionsBuilder.EnableServiceProviderCaching(false);
        optionsBuilder.UseModel(BloggingContextModel.Instance);
    }
}
