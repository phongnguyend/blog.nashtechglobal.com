using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EfCoreVsDapper;

[Config(typeof(BenchmarkConfig))]
[MemoryDiagnoser]
public class Benchmarks
{
    private BloggingContext? _dbContext;
    private IDbConnection? _dbConnection;
    private Blog? _testBlog;

    [GlobalSetup]
    public async Task Setup()
    {
        _dbContext = new BloggingContext();
        _dbConnection = new SqliteConnection($"Data Source={_dbContext.DbPath}");

        var blogs = new List<Blog>();
        for (int i = 1; i <= 1000; i++)
        {
            var blog = new Blog { BlogId = i, Url = $"https://blog.phongnguyen.com/posts/{i}" };
            blogs.Add(blog);
        }

        await _dbContext.Blogs.AddRangeAsync(blogs);
        await _dbContext.SaveChangesAsync();

        _testBlog = new Blog { BlogId = Random.Shared.Next(1, 1000) };
    }

    [GlobalCleanup]
    public async Task Cleanup()
    {
        await _dbContext!.Blogs.ExecuteDeleteAsync();
        await _dbContext.SaveChangesAsync();
    }

    [Benchmark]
    public async Task<Blog?> EFCore_Single()
    {
        return await _dbContext!.Blogs.SingleOrDefaultAsync(x => x.BlogId == _testBlog!.BlogId);
    }

    [Benchmark]
    public async Task<Blog?> EFCore_First()
    {
        return await _dbContext!.Blogs.FirstOrDefaultAsync(x => x.BlogId == _testBlog!.BlogId);
    }

    [Benchmark]
    public async Task<Blog?> Dapper_GetById()
    {
        return await _dbConnection!.QuerySingleOrDefaultAsync<Blog>("SELECT * FROM Blogs WHERE BlogId=@BlogId LIMIT 1", new { _testBlog!.BlogId });
    }


    private static readonly Func<BloggingContext, int, Task<Blog?>> SingleBlogAsync = EF.CompileAsyncQuery(
        (BloggingContext context, int blogId) => context.Blogs.SingleOrDefault(x => x.BlogId == blogId));

    [Benchmark]
    public async Task<Blog?> EFCore_Single_Compiled()
    {
        return await SingleBlogAsync(_dbContext!, _testBlog!.BlogId);
    }

    private static readonly Func<BloggingContext, int, Task<Blog?>> FirstBlogAsync = EF.CompileAsyncQuery(
        (BloggingContext context, int id) => context.Blogs.FirstOrDefault(x => x.BlogId == id));

    [Benchmark]
    public async Task<Blog?> EFCore_First_Compiled()
    {
        return await FirstBlogAsync(_dbContext!, _testBlog!.BlogId);
    }
}
