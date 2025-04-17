using System;
using System.Linq;

public class Example
{
    public static void Main(string[] args)
    {
        string[] names = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };

        var shortNames = names.Where(name => name.Length == 3);

        Console.WriteLine("Имена длиной 3:");
        foreach (var name in shortNames)
        {
            Console.WriteLine(name);
        }
    }
}
