// Dictionary in C#

// Dictionary is a generic collection which is generally used to store key/value pairs
// In Dictionary, the key cannot be null, but value can be.
// Key must be unique.
// In Dictionary, you can only store same types of elements.


using System;
using System.Collections.Generic;

// Customkey class is created to override the GetHashCode and Equals method
class CustomKey
{
    public int Id { get; set; }
    public string Name { get; set;}

    public override int GetHashCode()
    {
        // Combine the hash codes of the properties
        return Id.GetHashCode() ^ Name.GetHashCode();
    }
    // Override the Equals method to compare the properties of the objects
    public override bool Equals(object? obj)
    {
        if(obj is CustomKey other)
        {
            return Id == other.Id && Name == other.Name;
        }
        return false;
    }
}
// UserInfo class is created to store the key/value pair in the Dictionary
class UserInfo
{
    public string Email { get; set; }
    public string Address { get; set; }
}



class Example
{
    static public void Main ()
    {
        // Creating a Dictionary
        Dictionary<string, int> dict = new Dictionary<string, int> ();

        // Adding key/value pairs in Dictionary
        dict.Add ("A", 1);
        dict.Add ("B", 2);
        dict.Add ("C", 3);
        dict.Add ("D", 4);

        // Creating a Dictionary without using Add method
        Dictionary<string, int> dict1 = new Dictionary<string, int> ()
        {
            {"A", 1},
            {"B", 2},
            {"C", 3},
            {"D", 4}
        };


        // The key/value pair of the Dictionary is accessed using three different ways:
        // 1. Using for loop
        // 2. Using index
        // 3. Using foreach loop

        // 1. Using for loop
        Console.WriteLine("For loop:");

        for (int i = 0; i < dict.Count; i++)
        {
            Console.WriteLine ("Key: {0}, Value: {1}", dict.Keys.ElementAt (i), dict.Values.ElementAt (i));
        }

        Console.WriteLine();
        // 2. Using index
        Console.WriteLine("Index: ");
        Console.WriteLine ("Key: {0}, Value: {1}", dict["A"], dict["B"]);

        Console.WriteLine();
        // 3. Using foreach loop
        Console.WriteLine("Foreach loop: ");
        foreach (KeyValuePair<string, int> ele1 in dict)
        {
            Console.WriteLine ("Key: {0}, Value: {1}", ele1.Key, ele1.Value);
        }


        // Removing key/value pair from Dictionary
        dict.Remove ("A");
        dict.Remove ("B");

        Console.WriteLine();
        // Using foreach loop to print the Dictionary after removing key/value pair
        Console.WriteLine("Foreach loop with removed: ");
        foreach (KeyValuePair<string, int> ele1 in dict)
        {
            Console.WriteLine("Key: {0}, Value: {1}", ele1.Key, ele1.Value);
        }

        // Clearing the Dictionary
        dict.Clear ();

        Console.WriteLine();
        // Printing the Dictionary after clearing
        Console.WriteLine("Dictionary cleared: ");
        Console.WriteLine("Total number of key/value pairs present in dict:{0}", dict.Count);

        Console.WriteLine();
        // Checking whether the key is present in the Dictionary or not
        Console.WriteLine("Checking key: ");
        if (dict1.ContainsKey ("A")==true)
        {
            Console.WriteLine("Key A is present in the Dictionary");
        }
        else
        {
            Console.WriteLine("Key A is not present in the Dictionary");
        }

        Console.WriteLine();
        // Checking whether the value is present in the Dictionary or not
        Console.WriteLine("Checking Value: ");
        if (dict1.ContainsValue (2)==true)
        {
            Console.WriteLine("Value 2 is present in the Dictionary");
        }
        else
        {
            Console.WriteLine("Value 2 is not present in the Dictionary");
        }

        Console.WriteLine();
        // A collision in a dictionary occurs when two different keys hash to the same index in the underlying array.
        // This means that the hash function generates the same hash code for different keys,
        // leading to a situation where multiple keys would be stored in the same bucket.

        // How to handle collision in Dictionary
        // Choosing a good hash function is the best way to avoid collisions.

        // CustomKey class is created to override the GetHashCode and Equals method
        // CustomKey class is used as a key in the Dictionary
        // CustomKey class is created to reduce the likelihood of collisions
        Dictionary<CustomKey, UserInfo> dict2 = new Dictionary<CustomKey, UserInfo> ();

        CustomKey userKey1 = new CustomKey { Id = 1, Name = "Alice" };
        CustomKey userKey2 = new CustomKey { Id = 2, Name = "Bob" };

        dict2.Add (userKey1, new UserInfo { Email = "Alice@gmail.com", Address = "123 AliceHighway"});
        dict2.Add (userKey2, new UserInfo { Email = "Bob@gmail.com", Address = "456 BobHighway" });

        Console.WriteLine("Dictionary 2 with reduction of likelihood of collisions:");
        Console.WriteLine("User1 Mail: " + dict2[userKey1].Email);
        Console.WriteLine("User1 Address: " + dict2[userKey1].Address);
        Console.WriteLine("User2 Mail: " + dict2[userKey2].Email);
        Console.WriteLine("User2 Address: " + dict2[userKey2].Address);


    }
}



// End of Dictionary in C#


