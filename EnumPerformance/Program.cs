// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using EnumPerformance;

//Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<Benchmarks>();

Day monday = Day.Monday;

//blog about NetEscapades.EnumGenerator https://andrewlock.net/netescapades-enumgenerators-a-source-generator-for-enum-performance/

//string toString = monday.ToString();
string toString = monday.ToStringFast();

//bool isDefined = Enum.IsDefined(monday);
bool isDefined = DayExtensions.IsDefined(monday);

string? name = Enum.GetName(monday);

//string[] names = Enum.GetNames<Day>();
string[] names = DayExtensions.GetNames();

//Day[] values = Enum.GetValues<Day>();
Day[] values = DayExtensions.GetValues();

//bool parsed = Enum.TryParse<Day>("Monday", out Day day);
bool parsed = DayExtensions.TryParse("Monday", out Day day);