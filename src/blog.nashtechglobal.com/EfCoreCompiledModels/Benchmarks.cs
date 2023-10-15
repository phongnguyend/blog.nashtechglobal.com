using BenchmarkDotNet.Attributes;
using EfCoreCompiledModels.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCompiledModels;

[Config(typeof(BenchmarkConfig))]
[MemoryDiagnoser]
public class Benchmarks
{
    [Benchmark]
    public async Task BloggingContext()
    {
        using var context = new BloggingContext();
        await context.Blogs001.ToListAsync();
    }
}
