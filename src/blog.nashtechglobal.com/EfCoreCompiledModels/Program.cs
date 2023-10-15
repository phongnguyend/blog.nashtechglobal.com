using BenchmarkDotNet.Running;
using EfCoreCompiledModels;

var summary = BenchmarkRunner.Run<Benchmarks>();