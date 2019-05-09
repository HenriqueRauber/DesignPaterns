using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedList StudentRecords = new SortedList();
            StudentRecords.Add("Rodrigo");
            StudentRecords.Add("Maria");
            StudentRecords.Add("João");
            StudentRecords.Add("Carlos");
            StudentRecords.Add("Ana");

            StudentRecords.SetSortStrategy(new QuickSort());
            StudentRecords.Sort();

            StudentRecords.SetSortStrategy(new ShellSort());
            StudentRecords.Sort();

            StudentRecords.SetSortStrategy(new MergeSort());
            StudentRecords.Sort();

            Console.ReadKey();
        }
    }
}
