using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        int sum = 0;
        int larg = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            string sNumber = Console.ReadLine();
            number = int.Parse(sNumber);
            if (number != 0)
            {
                numbers.Add(number);
                // aver += 1;
                sum += number;
                if (number > larg)
                {
                    larg = number;
                }
            }
        }
        int aver =  sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The averange is: {aver}");
        Console.WriteLine($"The largest number is: {larg}");
    }
}