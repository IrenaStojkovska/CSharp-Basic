Console.WriteLine("Exercise 05");

int[] integerArray = new int[5];
int sumOfAllNumbers = 0;

for (int i = 0; i < integerArray.Length; i++)
{
    Console.WriteLine("Enter number: ");
    bool isNumberInteger = int.TryParse(Console.ReadLine(), out int number);
    if (isNumberInteger)
    {
        integerArray[i] = number;
        sumOfAllNumbers += number;
    }
    else
    {
        Console.WriteLine("You entered wrong data.");
        Array.Resize(ref integerArray, integerArray.Length + 1);
    }
}

Console.WriteLine($"The sum of all integers in array is : {sumOfAllNumbers}");