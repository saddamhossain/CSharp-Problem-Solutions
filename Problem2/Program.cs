Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = Subtract(firstNumber, secondNumber);

Console.WriteLine("The subtract is: " + result);

int Subtract(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}