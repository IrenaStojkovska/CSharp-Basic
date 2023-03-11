Console.WriteLine("StudentGroup");

string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Zdravka", "Petkana", "Stanka", "Branka", "Trajanka" };

Console.WriteLine("Enter student group (there are 1 and 2) to print : ");

bool isNumberInteger = int.TryParse(Console.ReadLine(), out int number);
if (isNumberInteger)
{
    if (number == 1)
    {
        Console.WriteLine("The students in G1 are:");
        foreach (string arrayItem in studentsG1)
        {
            Console.WriteLine(arrayItem);
        }
    }
    else if (number == 2)
    {
        Console.WriteLine("The students in G2 are:");
        foreach (string arrayItem in studentsG2)
        {
            Console.WriteLine(arrayItem);
        }
    }
    else
    {
        Console.WriteLine("You entered wrong data.");
    }
}
else
{
    Console.WriteLine("You entered wrong data.");
}

