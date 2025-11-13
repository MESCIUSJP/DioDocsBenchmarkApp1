using BenchmarkDotNet.Running;
using DioDocsBenchmarkApp1;
using System;

var summary = BenchmarkRunner.Run<Benchmark>();
Console.ReadKey();
