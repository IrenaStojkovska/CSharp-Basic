Console.WriteLine("Average Number");
Console.WriteLine();

Console.WriteLine("Enter the first number :");
bool isFirstNumberInteger = int.TryParse(Console.ReadLine(), out int firstNumber);
Console.WriteLine("Enter the second number :");
bool isSecondNumberInteger = int.TryParse(Console.ReadLine(), out int secondNumber);
Console.WriteLine("Enter the third number :");
bool isThirdNumberInteger = int.TryParse(Console.ReadLine(), out int thirdNumber);
Console.WriteLine("Enter the fourth number :");
bool isFourthNumberInteger = int.TryParse(Console.ReadLine(), out int fourthNumber);

if (isFirstNumberInteger && isSecondNumberInteger && isThirdNumberInteger && isFourthNumberInteger)
{
    int result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
    Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", " + fourthNumber + " is: " + result);
}
else
{
    Console.WriteLine("You entered wrong data.");
}