using BenchmarkDotNet.Running;
using CopilotModelsBenchmark;

var summary = BenchmarkRunner.Run<BenchmarkManager>();