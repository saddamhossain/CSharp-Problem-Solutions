﻿Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = Multiply(firstNumber, secondNumber);

Console.WriteLine("The multiplication is: " + result);

int Multiply(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}