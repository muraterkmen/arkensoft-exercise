
using Arkensoft.Exercise;
using System.Linq;

FrequencyQueries frequency = new FrequencyQueries();

SummaryRanges ranges = new SummaryRanges();
var summary = ranges.GetSummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 });

Console.WriteLine("[0, 1, 2, 4, 5, 7] --> " + string.Join( ',', summary));

 summary = ranges.GetSummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 });

Console.WriteLine("[0, 2, 3, 4, 6, 8, 9] --> " + string.Join(',', summary));


Console.WriteLine("Hello, World!");

