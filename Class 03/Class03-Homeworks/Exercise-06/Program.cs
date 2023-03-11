Console.WriteLine("Exercise 06");
string[] namesArray = new string[0];

int i = 0;
while (true)
{
    Array.Resize(ref namesArray, namesArray.Length + 1);
    Console.WriteLine("Enter name");
    string name = Console.ReadLine();
    namesArray[i] = name;

    string answerCheck;
    while (true)
    {
        Console.WriteLine("Do you want to enter another name Y/N : ");
        answerCheck = Console.ReadLine().ToUpper();

        if (answerCheck != "Y" && answerCheck != "N")
        {
            Console.WriteLine("You entered wrong data.");
        }
        else
        {
            break;
        }
    }

    switch (answerCheck)
    {
        case "Y":
            i++;
            continue;
        case "N":
            Console.WriteLine("Names in array : ");
            foreach (string arrayItem in namesArray)
            {
                Console.WriteLine(arrayItem);
            }
            break;
    }
    break;
}
