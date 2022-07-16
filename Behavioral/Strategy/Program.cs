using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studantsRecords = new SortedList();
            
            studantsRecords.Add("Rodrigo");
            studantsRecords.Add("Maria");
            studantsRecords.Add("João");
            studantsRecords.Add("Carlos");
            studantsRecords.Add("Ana");
            
            studantsRecords.SetSortStrategy(new QuickSort());
            studantsRecords.Sort();
            
            studantsRecords.SetSortStrategy(new ShellSort());
            studantsRecords.Sort();
            
            studantsRecords.SetSortStrategy(new MergeShort());
            studantsRecords.Sort();
        }
    }
}