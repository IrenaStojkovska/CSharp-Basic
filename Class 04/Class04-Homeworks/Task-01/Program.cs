Console.WriteLine("Task 01");

Console.WriteLine("Enter string longer than 4 characters: ");
string enterString = Console.ReadLine();
if (enterString.Length > 4)
{
    string lastCharacters = enterString.Substring(enterString.Length - 5);
    Console.WriteLine(lastCharacters);
}
else
{
    Console.WriteLine("You entered shorter string.");
}