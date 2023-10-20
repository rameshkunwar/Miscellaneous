using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace EnumPerformance
{
    [SimpleJob(RuntimeMoniker.Net70, baseline: true)]
    [MemoryDiagnoser(false)]
    [HideColumns("Job", "RatioSD", "Error")]
    public class Benchmarks
    {
        private readonly Day _monday = Day.Monday;

        [Benchmark]
        public bool IsDefined()
        {
            return Enum.IsDefined(_monday);
        }

        [Benchmark]
        public string? GetName()
        {
            return Enum.GetName(_monday);
        }

        [Benchmark]
        public string[] GetNames()
        {
            return Enum.GetNames<Day>();
        }

        [Benchmark]
        public Day[] GetValues()
        {
            return Enum.GetValues<Day>();
        }
        [Benchmark]
        public string? EnumToString()
        {
            return _monday.ToString();
        }

        [Benchmark]
        public (bool, Day) TryParse()
        {
            bool parsed = Enum.TryParse<Day>("Monday", out Day day);
            return (parsed, day);
        }
    }
}
