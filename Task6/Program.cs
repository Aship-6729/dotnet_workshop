// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };

fruits.Add("Orange");

fruits.Remove("Banana");

Console.WriteLine("List of Fruits:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Orange" }
        };

fruitDictionary.Add(4, "Grapes");


Console.WriteLine("\nFruit Dictionary:");
foreach (KeyValuePair<int, string> entry in fruitDictionary)
{
    Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
}