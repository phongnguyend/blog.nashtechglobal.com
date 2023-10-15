using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;

namespace EfCoreCompiledModels;

public class BenchmarkConfig : ManualConfig
{
    public BenchmarkConfig()
    {
        AddJob(Job.MediumRun.WithToolchain(InProcessNoEmitToolchain.Instance));
    }
}
