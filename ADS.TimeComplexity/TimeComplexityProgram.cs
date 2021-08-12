using System;
using System.Diagnostics;
using ADS.Generators;
using ADS.SimpleAlgorithms;

namespace ADS.TimeComplexity
{
    class TimeComplexityProgram
    {
        static void Main(string[] args)
        {
            DoSumOfElementsMeasurement();
        }

        static void DoSumOfElementsMeasurement()
        {
            Console.Write("Sum af elementer: Forvent O(n). Ticks: ");
            MeasurementAlgorithm algorithm = new();
            Stopwatch stopwatch = new();
            ArrayGenerator arrayGenerator = new();
            int[] array = arrayGenerator.GenerateArray(100, 2);
            stopwatch.Start();
            algorithm.SumOfElements(array);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
        }
    }
}