Console.WriteLine("Real Calculator");
Console.WriteLine();

Console.WriteLine("Enter the first number :");
bool isFirstNumberInteger = int.TryParse(Console.ReadLine(), out int firstNumber);
Console.WriteLine("Enter the second number :");
bool isSecondNumberInteger = int.TryParse(Console.ReadLine(), out int secondNumber);
Console.WriteLine("Enter the operation:");
string operation = Console.ReadLine();

if (isFirstNumberInteger && isSecondNumberInteger)
{
    if (operation == "+")
    {
        Console.Write("The result is: ");
        Console.Write(firstNumber + secondNumber);
    }
    else if (operation == "-")
    {
        Console.Write("The result is: ");
        Console.Write(firstNumber - secondNumber);
    }
    else if (operation == "*")
    {
        Console.Write("The result is: ");
        Console.Write(firstNumber * secondNumber);
    }
    else if (operation == "/")
    {
        Console.Write("The result is: ");
        Console.Write(firstNumber / secondNumber);
    }
    else
    {
        Console.WriteLine("You entered wrong operation");
    }
}
else
{
    Console.WriteLine("You entered wrong data.");
}