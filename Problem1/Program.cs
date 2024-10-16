Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = Sum(firstNumber, secondNumber);

Console.WriteLine("The sum is: " + result);

int Sum(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}