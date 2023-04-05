
static IList<string> FizzBuzz(int number)
{
    if (number / 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number / 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine("FizzBuzz");
    }
} 