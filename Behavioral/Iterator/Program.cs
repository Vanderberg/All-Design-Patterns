using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretAggregate aggregate = new ConcretAggregate();
            aggregate[0] = "Item A";
            aggregate[1] = "Item B";
            aggregate[2] = "Item C";
            aggregate[3] = "Item D";

            Iterator iterator = aggregate.CreateIterator();

            Console.WriteLine("Interagindo com a coleção: ");

            object item = iterator.First();

            int x = 0;
            while (item != null)
            {
                Console.WriteLine(item);

                if (x == 2)
                    item = iterator.CurrentItem();
                
                item = iterator.Next();
                x++;
            }
        }
    }
}