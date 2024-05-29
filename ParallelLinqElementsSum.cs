using System.Diagnostics;
using System.Numerics;

namespace ParallelAndThread;

public static class ParallelLinqElementsSum
{
    public static void Calculate(int startElement, int endElement)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        BigInteger numbersRangeSum = Enumerable.Range(startElement, endElement)
                                               .AsParallel()
                                               .Select(i => (BigInteger)i)
                                               .Aggregate((i, j) => i + j);
  
        stopwatch.Stop();
        Console.WriteLine($"Элементов: {endElement}. Сумма: {numbersRangeSum}. Время выполнения: {stopwatch.ElapsedMilliseconds} мс.");        
    }
}
