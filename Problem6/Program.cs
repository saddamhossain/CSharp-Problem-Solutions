// Create an instance of DictionaryPractice
DictionaryPractice dictionaryPractice = new DictionaryPractice();

// Create and print all key-value pairs
Console.WriteLine("Creating a dictionary of fruit prices (string keys and int values)...");
Dictionary<string, int> fruitPrices = dictionaryPractice.GetFruitPrices();

// Print the original dictionary
Console.WriteLine("\nAll fruit prices:");
foreach (var item in fruitPrices)
{
    Console.WriteLine($"{item.Key} costs {item.Value} dollars.");
}

// Access a specific value by key ("Apple")
Console.WriteLine("\nAccess the price of an Apple:");
int? applePrice = dictionaryPractice.GetPriceByFruit(fruitPrices, "Apple");
if (applePrice.HasValue)
{
    Console.WriteLine($"The price of an Apple is: {applePrice.Value} dollars.");
}
else
{
    Console.WriteLine("Apple is not in the dictionary.");
}

// Remove "Banana" from the dictionary
Console.WriteLine("\nRemoving 'Banana' from the dictionary...");
dictionaryPractice.RemoveFruit(fruitPrices, "Banana");

// Print the updated dictionary after removal
Console.WriteLine("\nAll fruit prices after removing 'Banana':");
foreach (var item in dictionaryPractice.GetAllFruits(fruitPrices))
{
    Console.WriteLine($"{item.Key} costs {item.Value} dollars.");
}