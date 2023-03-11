Console.WriteLine("SumOfEven");

int[] intArray = new int[6];
int sumOfEven = 0;
int whileIterator = 0;
while (whileIterator <= 5)
{
    Console.WriteLine($"Enter integer no.{whileIterator + 1} ");
    bool isNumberInteger = int.TryParse(Console.ReadLine(), out int number);
    if (isNumberInteger)
    {
        intArray[whileIterator] = number;
        whileIterator++;
        if (number % 2 == 0)
        {
            sumOfEven += number;
        }
    }
    else
    {
        Console.WriteLine("You entered wrong data.");
    }
}
Console.WriteLine($"The sum of even numbers in array is: {sumOfEven}.");
