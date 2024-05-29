using System.Diagnostics;
using System.Numerics;

namespace ParallelAndThread;

public static class ParallelThreadElementsSum
{
    public static void Calculate(int startElement, int endElement)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        var numbersRange = Enumerable.Range(startElement, endElement).ToArray();

        int threadAmount = CalculateRequiredNumberOfThreads(endElement);
        int arraySizeInThread = endElement / threadAmount;
        BigInteger[] partialSum = new BigInteger[arraySizeInThread];
        BigInteger totalSum = 0;

        Parallel.For(0, threadAmount, (counter) =>
        {
            BigInteger sum = 0;
            for (int i = counter * arraySizeInThread; i < (counter + 1) * arraySizeInThread; i++)
                sum += numbersRange[i];

            partialSum[counter] = sum;
        });

        foreach (var item in partialSum)
        {
            totalSum += item;
        }

        stopwatch.Stop();
        Console.WriteLine($"Элементов: {endElement}. Сумма: {totalSum}. Время выполнения: {stopwatch.ElapsedMilliseconds} мс.");
    }

    private static int CalculateRequiredNumberOfThreads(int elementsCount)
    {
        int threadAmount = 1;

        if (elementsCount > 100_000)
            threadAmount = 5;

        return threadAmount;
    }
}
