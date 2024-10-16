namespace Problem5;

public class ListPractice
{ 
    // Method to initialize and add fruits to the list
    public List<string> GetFruitList()
    {
        // Initialize the list and add fruits directly
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        return fruits;
    }

    // Method to remove a specific fruit from the list
    public void RemoveFruit(List<string> fruits, string fruitToRemove)
    {
        fruits.Remove(fruitToRemove);
    }

    // Method to check if a specific fruit exists in the list
    public bool IsFruitInList(List<string> fruits, string fruitToCheck)
    {
        return fruits.Contains(fruitToCheck);
    }

    // Method to return the list of fruits
    public List<string> GetAllFruits(List<string> fruits)
    {
        return fruits;
    }
}
