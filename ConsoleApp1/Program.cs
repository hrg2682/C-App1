using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List of strings
        List<string> stringList = new List<string>();

        // Add elements to the list
        stringList.Add("Item A");
        stringList.Add("Item B");
        stringList.Add("Item C");

        // Access elements by index
        Console.WriteLine("List elements:");
        for (int i = 0; i < stringList.Count; i++)
        {
            Console.WriteLine($"Item {i + 1}: {stringList[i]}");
        }

        // Remove an element
        //stringList.Remove("Item B");

        // Check if an element exists
        if (stringList.Contains("Item B"))
        {
            Console.WriteLine("Item B is in the list.");
        }
        else
        {
            Console.WriteLine("Item B is not in the list.");
        }

        // Display the updated list
        Console.WriteLine("\nUpdated list elements:");
        foreach (var item in stringList)
        {
            Console.WriteLine(item);
        }
    }
}
