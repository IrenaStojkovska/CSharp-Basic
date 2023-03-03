Console.WriteLine("Swap Numbers");

Console.WriteLine("Input the first number :");
bool isFirstNumberInteger = int.TryParse(Console.ReadLine(), out int firstNumber);
Console.WriteLine("Input the second number :");
bool isSecondNumberInteger = int.TryParse(Console.ReadLine(), out int secondNumber);


if (isFirstNumberInteger && isSecondNumberInteger)
{
    (firstNumber, secondNumber) = (secondNumber, firstNumber);
    Console.WriteLine("After swapping: ");
    Console.WriteLine("First number: " + firstNumber);
    Console.WriteLine("Second number: " + secondNumber);
}
else
{
    Console.WriteLine("You entered wrong data.");
}