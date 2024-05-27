using ParallelAndThread;

Console.WriteLine("Вычисление суммы элементов массива интов (обычное)");
RegularElementsSum.Calculate(1, 100_000);
RegularElementsSum.Calculate(1, 1_000_000);
RegularElementsSum.Calculate(1, 10_000_000);

Console.WriteLine("\nВычисление суммы элементов массива интов (параллельное Thread)");
ParallelThreadElementsSum.Calculate(1, 100_000);
ParallelThreadElementsSum.Calculate(1, 1_000_000);
ParallelThreadElementsSum.Calculate(1, 10_000_000);

Console.WriteLine("\nВычисление суммы элементов массива интов (параллельное LINQ)");
ParallelLinqElementsSum.Calculate(1, 100_000);
ParallelLinqElementsSum.Calculate(1, 1_000_000);
ParallelLinqElementsSum.Calculate(1, 10_000_000);