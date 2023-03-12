Console.WriteLine("Task 03");

Console.WriteLine("Write number: ");
bool isIntegerParsed = int.TryParse(Console.ReadLine(), out int number);
int sum = 0;

if (isIntegerParsed)
{
    SumCal(number);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("You entered wrong data.");
}

void SumCal(int number)
{
    string stringConvert = Convert.ToString(number);

    for (int i = 0; i < stringConvert.Length; i++)
        sum += Convert.ToInt32(stringConvert.Substring(i, 1));
}