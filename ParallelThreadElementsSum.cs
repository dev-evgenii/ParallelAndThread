using System.Diagnostics;
using System.Numerics;

namespace ParallelAndThread;

public static class ParallelThreadElementsSum
{
    public static void Calculate(int startElement, int endElement)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        var numbersRange = Enumerable.Range(startElement, endElement);      
        object sync = new();
        BigInteger numbersRangeSum = 0;

        Parallel.ForEach(numbersRange, number =>
        {
            lock (sync)
                numbersRangeSum += number;            
        });

        Console.WriteLine($"Элементов: {endElement}. Сумма: {numbersRangeSum}. Время выполнения: {stopwatch.ElapsedMilliseconds} мс.");
        stopwatch.Stop();
    }
}
