// Create an instance of ListPractice
ListPractice listPractice = new ListPractice();

// Get the initialized list of fruits with fruits.Add inside GetFruitList
List<string> fruits = listPractice.GetFruitList();

Console.WriteLine("Original list of fruit:");

foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Remove "Apple" from the list
listPractice.RemoveFruit(fruits, "Apple");

// Check if "Banana" is still in the list
if(listPractice.IsFruitInList(fruits, "Banana"))
{
    Console.WriteLine("Banana is still in the list");
}

// Print the list after removing "Apple"
Console.WriteLine("Remaining fruits after removal:");
foreach(var fruit in listPractice.GetAllFruits(fruits))
{
    Console.WriteLine(fruit);
}

