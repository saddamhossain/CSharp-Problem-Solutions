namespace Problem6;

public class DictionaryPractice
{
    // Method to create and return a dictionary with initial values
    public Dictionary<string, int> GetFruitPrices()
    {
        Dictionary<string, int> fruitPrices = new Dictionary<string, int>();

        fruitPrices.Add("Apple", 10);
        fruitPrices.Add("Banana", 15);
        fruitPrices.Add("Cherry", 20);

        return fruitPrices;
    }

    // Method to access a value by key
    public int? GetPriceByFruit(Dictionary<string, int> fruitPrices, string fruitName)
    {
        if (fruitPrices.ContainsKey(fruitName))
        {
            return fruitPrices[fruitName];
        }
        return null; // Return null if fruit is not found
    }

    // Method to remove a key-value pair
    public void RemoveFruit(Dictionary<string, int> fruitPrices, string fruitName)
    {
        fruitPrices.Remove(fruitName);
    }

    // Method to return all key-value pairs
    public Dictionary<string, int> GetAllFruits(Dictionary<string, int> fruits)
    {
        return fruits;
    }

}
