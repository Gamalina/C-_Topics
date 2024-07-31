using System;
using System.Collections.Generic;

// A set is a collection of distinct elements, typically used to store unique items without any particular order.
// Sets are useful when you need to ensure that no duplicates are present in your collection.

// In C#, you can use the HashSet<T> class to create a set.
class Sets {
    static public void Main()
    {
        Console.WriteLine("A set is a collection of distinct elements, typically used to store unique items without any particular order.");
        Console.WriteLine("Sets are useful when you need to ensure that no duplicates are present in your collection.");
        HashSet<int> numbers = new HashSet<int>();

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(1); // Duplicate values are ignored

        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }


        bool containsTwo = numbers.Contains(2);
        Console.WriteLine($"Set contains 2: {containsTwo}");

        numbers.Remove(2);
        Console.WriteLine($"Set contains 2 after removal: {numbers.Contains(2)}");
    }
}
