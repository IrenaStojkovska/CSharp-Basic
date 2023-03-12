Console.WriteLine("Task 04 - AgeCalculator");

Console.WriteLine("Enter your birth date(month.date.year): ");
bool isNumberParsed = DateTime.TryParse(Console.ReadLine(), out DateTime birthDate);
DateTime todayDate = DateTime.Today;

if (isNumberParsed)
{
    int compareDates = todayDate.CompareTo(birthDate);
    int age = AgeCalculator(birthDate);
    if (compareDates < 0)
    {
        Console.WriteLine($"You are not born yet!!Wait {age * (-1)} years, than try again.");
    }
    if (compareDates == 0)
    {
        Console.WriteLine($"You've just born!!! You have {age} years.");
    }
    else if (compareDates > 0)
    {
        if (todayDate.Month >= birthDate.Month)
        {
            if (todayDate.Day > birthDate.Day)
            {
                Console.WriteLine($"You have {age} years.");
            }
            else if (todayDate.Day == birthDate.Day)
            {
                Console.WriteLine($"Today is you birthday!! You have {age} years.");
            }
        }
        else
        {
            Console.WriteLine($"You have {age - 1} years.");
        }
    }
}
else
{
    Console.WriteLine("You enter wrong date format.");
}

int AgeCalculator(DateTime birthDate)
{
    int age = todayDate.Year - birthDate.Year;
    return age;
}










