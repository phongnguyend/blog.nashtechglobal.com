using BenchmarkDotNet.Running;
using EfCoreVsDapper;

var summary = BenchmarkRunner.Run<Benchmarks>();