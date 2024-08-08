class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert the number: ");
        int desiredNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(FizzBuzz(desiredNumber)); 
    }

    private static string FizzBuzz(int value)
    {
        if (value % 5 == 0 && value % 3 == 0) {
            return "FizzBuzz";
        }
        else if (value % 5 == 0)
        {
            return "Buzz";
        }
        else if (value % 3 == 0)
        {
            return "Fizz";
        }
        else
        {
            return value.ToString();
        }
    }
}