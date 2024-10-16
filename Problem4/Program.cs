Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = Divide(firstNumber, secondNumber);

Console.WriteLine("The divide is: " + result);

int Divide(int firstNumber, int secondNumber)
{
    return firstNumber / secondNumber;
}