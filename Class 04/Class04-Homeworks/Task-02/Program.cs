Console.WriteLine("Task 02");

Console.WriteLine("Enter sentence: ");
string sentenceString = Console.ReadLine();
string[] result = sentenceString.Split(" ");
int i = 0;
foreach (string arrayString in result)
{
    Console.WriteLine($"{i + 1}. {arrayString}");
    i++;
}