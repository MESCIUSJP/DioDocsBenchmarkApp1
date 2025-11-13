using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using DioDocsBenchmarkApp1;
using System;
using System.Linq;

var summary = BenchmarkRunner.Run<Benchmark>();
Console.ReadKey();
