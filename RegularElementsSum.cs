using System.Diagnostics;
using System.Numerics;

namespace ParallelAndThread;

public static class RegularElementsSum
{
    public static void Calculate(int startElement, int endElement)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        BigInteger totalSum = 0;
        var numbersRange = Enumerable.Range(startElement, endElement).ToArray();

        for ( var j = 0; j < numbersRange.Length; j++)
        {
            totalSum += numbersRange[j];
        }
    
        stopwatch.Stop();
        Console.WriteLine($"Элементов: {endElement}.  Сумма: {totalSum}. Время выполнения: {stopwatch.ElapsedMilliseconds} мс.");        
    }
}
